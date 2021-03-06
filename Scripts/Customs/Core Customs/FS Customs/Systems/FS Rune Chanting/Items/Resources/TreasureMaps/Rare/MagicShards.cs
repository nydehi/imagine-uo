using System;
using Server.Items;

namespace Server.Items
{
	public class MagicShards : Item
	{
		[Constructable]
		public MagicShards() : base( 8762 + Utility.RandomMinMax( 0, 15 ) )
		{
			Name = "magic shards";
			Hue = 1462;
			Weight = 1.0;
			ItemValue = ItemValue.Resource;
		}

		public MagicShards( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}