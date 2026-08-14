using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20000AC")]
public class AvatarProfileData : CsvDataIndexedReading
{
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x8")]
	private string _003CProfileTitle_003Ek__BackingField;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0xC")]
	private string _003COccupation_003Ek__BackingField;

	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x10")]
	private string _003CAge_003Ek__BackingField;

	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x14")]
	private string _003CBirthday_003Ek__BackingField;

	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x18")]
	private string _003CHobby_003Ek__BackingField;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CRelationship1_003Ek__BackingField;

	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x20")]
	private string _003CRelationship2_003Ek__BackingField;

	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x24")]
	private string _003CRelationship3_003Ek__BackingField;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x28")]
	private uint _003CID_003Ek__BackingField;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003CLevel_003Ek__BackingField;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x30")]
	private uint _003CUnlockLevel_003Ek__BackingField;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x34")]
	private EInventory.AwardType _003CRewardType_003Ek__BackingField;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x38")]
	private uint _003CRewardId_003Ek__BackingField;

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003CRewardTime_003Ek__BackingField;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x40")]
	private EInventory.AwardType _003CRewardType2_003Ek__BackingField;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x44")]
	private uint _003CRewardId2_003Ek__BackingField;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x48")]
	private uint _003CRewardTime2_003Ek__BackingField;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x4C")]
	private uint _003CDebrisID_003Ek__BackingField;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x50")]
	private uint _003CDebrisCount_003Ek__BackingField;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x54")]
	private uint _003CItemID_003Ek__BackingField;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x58")]
	private uint _003CItemCount_003Ek__BackingField;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x5C")]
	public ResourceID RelationshipID1;

	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x60")]
	public ResourceID RelationshipID2;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x64")]
	public ResourceID RelationshipID3;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x68")]
	public uint RelationshipRealID1;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x6C")]
	public uint RelationshipRealID2;

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x70")]
	public uint RelationshipRealID3;

	[Token(Token = "0x170000AD")]
	public string ProfileTitle
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x234F0FC", Offset = "0x234F0FC", VA = "0x234F0FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x234F104", Offset = "0x234F104", VA = "0x234F104")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AE")]
	public string Occupation
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x234F10C", Offset = "0x234F10C", VA = "0x234F10C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x234F114", Offset = "0x234F114", VA = "0x234F114")]
		private set
		{
		}
	}

	[Token(Token = "0x170000AF")]
	public string Age
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x234F11C", Offset = "0x234F11C", VA = "0x234F11C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x234F124", Offset = "0x234F124", VA = "0x234F124")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B0")]
	public string Birthday
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x234F12C", Offset = "0x234F12C", VA = "0x234F12C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x234F134", Offset = "0x234F134", VA = "0x234F134")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B1")]
	public string Hobby
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x234F13C", Offset = "0x234F13C", VA = "0x234F13C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x234F144", Offset = "0x234F144", VA = "0x234F144")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B2")]
	public string Relationship1
	{
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x234F14C", Offset = "0x234F14C", VA = "0x234F14C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x234F154", Offset = "0x234F154", VA = "0x234F154")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B3")]
	public string Relationship2
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x234F15C", Offset = "0x234F15C", VA = "0x234F15C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x234F164", Offset = "0x234F164", VA = "0x234F164")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B4")]
	public string Relationship3
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x234F16C", Offset = "0x234F16C", VA = "0x234F16C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x234F174", Offset = "0x234F174", VA = "0x234F174")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B5")]
	public uint ID
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x234F17C", Offset = "0x234F17C", VA = "0x234F17C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x234F184", Offset = "0x234F184", VA = "0x234F184")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public uint Level
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x234F18C", Offset = "0x234F18C", VA = "0x234F18C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x234F194", Offset = "0x234F194", VA = "0x234F194")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public uint UnlockLevel
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x234F19C", Offset = "0x234F19C", VA = "0x234F19C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x234F1A4", Offset = "0x234F1A4", VA = "0x234F1A4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B8")]
	public EInventory.AwardType RewardType
	{
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x234F1AC", Offset = "0x234F1AC", VA = "0x234F1AC")]
		get
		{
			return default(EInventory.AwardType);
		}
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x234F1B4", Offset = "0x234F1B4", VA = "0x234F1B4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B9")]
	public uint RewardId
	{
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x234F1BC", Offset = "0x234F1BC", VA = "0x234F1BC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x234F1C4", Offset = "0x234F1C4", VA = "0x234F1C4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BA")]
	public uint RewardTime
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x234F1CC", Offset = "0x234F1CC", VA = "0x234F1CC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x234F1D4", Offset = "0x234F1D4", VA = "0x234F1D4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public EInventory.AwardType RewardType2
	{
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x234F1DC", Offset = "0x234F1DC", VA = "0x234F1DC")]
		get
		{
			return default(EInventory.AwardType);
		}
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x234F1E4", Offset = "0x234F1E4", VA = "0x234F1E4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	public uint RewardId2
	{
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x234F1EC", Offset = "0x234F1EC", VA = "0x234F1EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x234F1F4", Offset = "0x234F1F4", VA = "0x234F1F4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BD")]
	public uint RewardTime2
	{
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x234F1FC", Offset = "0x234F1FC", VA = "0x234F1FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x234F204", Offset = "0x234F204", VA = "0x234F204")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BE")]
	public uint DebrisID
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x234F20C", Offset = "0x234F20C", VA = "0x234F20C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x234F214", Offset = "0x234F214", VA = "0x234F214")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BF")]
	public uint DebrisCount
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x234F21C", Offset = "0x234F21C", VA = "0x234F21C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x234F224", Offset = "0x234F224", VA = "0x234F224")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public uint ItemID
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x234F22C", Offset = "0x234F22C", VA = "0x234F22C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x234F234", Offset = "0x234F234", VA = "0x234F234")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C1")]
	public uint ItemCount
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x234F23C", Offset = "0x234F23C", VA = "0x234F23C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x234F244", Offset = "0x234F244", VA = "0x234F244")]
		private set
		{
		}
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x234F0F4", Offset = "0x234F0F4", VA = "0x234F0F4")]
	public AvatarProfileData()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x234F24C", Offset = "0x234F24C", VA = "0x234F24C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x234F2D4", Offset = "0x234F2D4", VA = "0x234F2D4", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x234FF68", Offset = "0x234FF68", VA = "0x234FF68", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x23518BC", Offset = "0x23518BC", VA = "0x23518BC")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x23518C4", Offset = "0x23518C4", VA = "0x23518C4")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
