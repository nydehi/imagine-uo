using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{		
	public class CutsBothWaysQuest : BaseQuest
	{				
		/* Cuts Both Ways */
		public override object Title{ get{ return 1073913; } }
		
		/* What would you say is a typical human instrument of war? Is a broadsword a typical example? 
		I wish to see more of such human weapons, so I would gladly trade elven knowledge for human steel. */	
		public override object Description{ get{ return 1074103; } }
		
		/* I will patiently await your reconsideration. */
		public override object Refuse{ get{ return 1073921; } }
		
		/* I will be in your debt if you bring me broadswords. */
		public override object Uncomplete{ get{ return 1073959; } }
		
		/* Enjoy my thanks for your service. */
		public override object Complete{ get{ return 1073978; } }
	
		public CutsBothWaysQuest() : base()
		{			
			AddObjective( new ObtainObjective( typeof( Broadsword ), "broadswords", 12, 0xF5E ) );
			
			AddReward( new BaseReward( typeof( SmithsCraftsmanSatchel ), 1074282 ) );
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
	
	public class DragonProtectionQuest : BaseQuest
	{				
		/* Dragon Protection */
		public override object Title{ get{ return 1073915; } }
		
		/* Mankind, I am told, knows how to take the scales of a terrible dragon and forge them into powerful 
		armor. Such a feat of craftsmanship! I would give anything to view such a creation - I would even teach 
		some of the prize secrets of the elven people. */	
		public override object Description{ get{ return 1074105; } }
		
		/* I will patiently await your reconsideration. */
		public override object Refuse{ get{ return 1073921; } }
		
		/* I will be in your debt if you bring me dragon armor. */
		public override object Uncomplete{ get{ return 1073961; } }
		
		/* Enjoy my thanks for your service. */
		public override object Complete{ get{ return 1073978; } }
	
		public DragonProtectionQuest() : base()
		{			
			AddObjective( new ObtainObjective( typeof( DragonHelm ), "dragon helms", 10, 0x2645 ) );
			
			AddReward( new BaseReward( typeof( SmithsCraftsmanSatchel ), 1074282 ) );
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
	
	public class NothingFancyQuest : BaseQuest
	{				
		/* Nothing Fancy */
		public override object Title{ get{ return 1073911; } }
		
		/* I am curious to see the results of human blacksmithing. To examine the care and quality 
		of a simple item. Perhaps, a simple bascinet helmet? Yes, indeed -- if you could bring to 
		me some bascinet helmets, I would demonstrate my gratitude. */	
		public override object Description{ get{ return 1074101; } }
		
		/* I will patiently await your reconsideration. */
		public override object Refuse{ get{ return 1073921; } }
		
		/* I will be in your debt if you bring me bascinets. */
		public override object Uncomplete{ get{ return 1073957; } }
		
		/* Enjoy my thanks for your service. */
		public override object Complete{ get{ return 1073978; } }
	
		public NothingFancyQuest() : base()
		{			
			AddObjective( new ObtainObjective( typeof( Bascinet ), "bascinets", 15, 0x140C ) );
			
			AddReward( new BaseReward( typeof( SmithsCraftsmanSatchel ), 1074282 ) );
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
	
	public class TheBulwarkQuest : BaseQuest
	{				
		/* The Bulwark */
		public override object Title{ get{ return 1073912; } }
		
		/* The clank of human iron and steel is strange to elven ears. For instance, the metallic heater shield 
		which human warriors carry into battle. It is odd to an elf, but nevertheless intriguing. Tell me friend, 
		could you bring me such an example of human smithing skill? */	
		public override object Description{ get{ return 1074102; } }
		
		/* I will patiently await your reconsideration. */
		public override object Refuse{ get{ return 1073921; } }
		
		/* I will be in your debt if you bring me heater shields. */
		public override object Uncomplete{ get{ return 1073958; } }
		
		/* Enjoy my thanks for your service. */
		public override object Complete{ get{ return 1073978; } }
	
		public TheBulwarkQuest() : base()
		{			
			AddObjective( new ObtainObjective( typeof( HeaterShield ), "heater shields", 10, 0x1B76 ) );
			
			AddReward( new BaseReward( typeof( SmithsCraftsmanSatchel ), 1074282 ) );
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
	
	public class Lohn : MondainQuester
	{
		public override Type[] Quests
		{ 
			get{ return new Type[] 
			{ 
				typeof( CutsBothWaysQuest ),
				typeof( DragonProtectionQuest ),
				typeof( NothingFancyQuest ),
				typeof( TheBulwarkQuest )
			};} 
		}
		
		[Constructable]
		public Lohn() : base( "Lohn", "the metal weaver" )
		{			
			SetSkill( SkillName.Meditation, 60.0, 83.0 );
			SetSkill( SkillName.Focus, 60.0, 83.0 );
		}
		
		public Lohn( Serial serial ) : base( serial )
		{
		}		
		
		public override void InitBody()
		{
			InitStats( 100, 100, 25 );
			
			Female = false;
			Race = Race.Elf;
			
			Hue = 0x8385;
			HairItemID = 0x2FC2;
			HairHue = 0x26B;
		}
		
		public override void InitOutfit()
		{
			AddItem( new Sandals( 0x901 ) );
			AddItem( new LongPants( 0x359 ) );
			AddItem( new ElvenShirt( 0x359 ) );
			AddItem( new SmithHammer() );
			AddItem( new FullApron( 0x1BB ) );
			AddItem( new GemmedCirclet() );
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