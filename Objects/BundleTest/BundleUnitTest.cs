using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Objects.Organization;
using Speckle.Core.Api;
using Speckle.Core.Credentials;
using Speckle.Core.Models;
using Speckle.Core.Transports;

namespace BundleTest
{
	[TestFixture]
	public class BundleUnitTest
	{
		const string simpleMeshStreamId = "4f5b4785b0";
		const string tennisBoxStreamId = "d66e18ac8c";

		string commitId;
		Client client;
		Bundle bundle;
		ServerTransport transport;

		[OneTimeSetUp]
		public void Setup()
		{
			// objects are on two different streams
			bundle = new Bundle("Baby Bundle", new List<BundleItem>()
			{
				new BundleItem(simpleMeshStreamId, new() { "994680a63e1df5d257d6a49d4f18c00f", "1e69d528871d9b8d9f8bb0e04191657b" }), // Simple meshes
				new BundleItem(tennisBoxStreamId, new() { "3a2409765ad998709745d2f2dbbf566b" }) // Speckle Tennis Box
			});

			client = new Client(AccountManager.GetDefaultAccount());
			transport = new ServerTransport(client.Account, simpleMeshStreamId);
		}

		[OneTimeTearDown]
		public async Task CleanUp()
		{
			// if (!string.IsNullOrEmpty(commitId))
			// 	await client.CommitDelete(new CommitDeleteInput { id = commitId, streamId = simpleMeshStreamId });

			transport.Dispose();
			client.Dispose();
		}

		[Test, Order(00)]
		public async Task CreateAndSendBundle()
		{
			// send the bundle as a commit object
			var objectId = await Operations.Send(bundle, new List<ITransport>() { transport });

			var commitInput = new CommitCreateInput
			{
				branchName = "main",
				message = "testing bundle object",
				objectId = objectId,
				streamId = transport.StreamId,
				totalChildrenCount = (int)bundle.GetTotalChildrenCount()
			};

			commitId = await client.CommitCreate(commitInput);

			Assert.IsNotNull(commitId);
		}

		[Test, Order(10)]
		public async Task ReceiveAndCheckBundle()
		{
			// now pull it down
			var commit = await client.CommitGet(simpleMeshStreamId, commitId);

			var receivedBundle = (Bundle)await Operations.Receive(commit.referencedObject, transport);
			Assert.IsNotNull(receivedBundle);

			Assert.IsTrue(receivedBundle.Equals(bundle));

			var bundledObjs = new Dictionary<string, List<Base>>();

			foreach (var item in receivedBundle.items)
			{
				transport = new ServerTransport(client.Account, item.streamId);

				var objs = new List<Base>(item.objectIds.Count);

				foreach (var id in item.objectIds)
				{
					var @base = await Operations.Receive(id, transport);

					Assert.IsNotNull(@base);
					objs.Add(@base);

					Console.WriteLine($"{item.streamId} with {@base.id}");
				}

				Assert.IsNotEmpty(objs);

				bundledObjs.Add(item.streamId, objs);

				transport.Dispose();
			}

			Assert.IsNotEmpty(bundledObjs);
			Assert.IsTrue(bundledObjs.Count == bundle.items.Count);
		}
	}
}