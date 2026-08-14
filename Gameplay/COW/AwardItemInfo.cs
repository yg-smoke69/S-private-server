using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EA0")]
public class AwardItemInfo : BaseItemInfo
{
	[Token(Token = "0x4011CD2")]
	[FieldOffset(Offset = "0x38")]
	private EInventory.AwardType _003CAward_Type_003Ek__BackingField;

	[Token(Token = "0x4011CD3")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003CAward_Max_Num_003Ek__BackingField;

	[Token(Token = "0x17001438")]
	public EInventory.AwardType Award_Type
	{
		[Token(Token = "0x60137B9")]
		[Address(RVA = "0x236D3A4", Offset = "0x236D3A4", VA = "0x236D3A4")]
		get
		{
			return default(EInventory.AwardType);
		}
		[Token(Token = "0x60137BA")]
		[Address(RVA = "0x236CCFC", Offset = "0x236CCFC", VA = "0x236CCFC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001439")]
	public uint Award_ID
	{
		[Token(Token = "0x60137BB")]
		[Address(RVA = "0x236D3AC", Offset = "0x236D3AC", VA = "0x236D3AC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137BC")]
		[Address(RVA = "0x236CC3C", Offset = "0x236CC3C", VA = "0x236CC3C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143A")]
	public uint Award_Num
	{
		[Token(Token = "0x60137BD")]
		[Address(RVA = "0x236D404", Offset = "0x236D404", VA = "0x236D404")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137BE")]
		[Address(RVA = "0x236CC9C", Offset = "0x236CC9C", VA = "0x236CC9C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143B")]
	public uint Award_Max_Num
	{
		[Token(Token = "0x60137BF")]
		[Address(RVA = "0x236D45C", Offset = "0x236D45C", VA = "0x236D45C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137C0")]
		[Address(RVA = "0x236CD04", Offset = "0x236CD04", VA = "0x236CD04")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143C")]
	public ResourceID Award_Item_IconRes
	{
		[Token(Token = "0x60137C1")]
		[Address(RVA = "0x236D464", Offset = "0x236D464", VA = "0x236D464")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60137C2")]
		[Address(RVA = "0x236D4BC", Offset = "0x236D4BC", VA = "0x236D4BC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143D")]
	public string Award_Item_Name
	{
		[Token(Token = "0x60137C3")]
		[Address(RVA = "0x236D51C", Offset = "0x236D51C", VA = "0x236D51C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60137C4")]
		[Address(RVA = "0x236D574", Offset = "0x236D574", VA = "0x236D574")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143E")]
	public int Award_Item_Type
	{
		[Token(Token = "0x60137C5")]
		[Address(RVA = "0x236D5D4", Offset = "0x236D5D4", VA = "0x236D5D4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60137C6")]
		[Address(RVA = "0x236D62C", Offset = "0x236D62C", VA = "0x236D62C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700143F")]
	public uint Award_Expire_Time
	{
		[Token(Token = "0x60137C7")]
		[Address(RVA = "0x236D68C", Offset = "0x236D68C", VA = "0x236D68C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137C8")]
		[Address(RVA = "0x236CD0C", Offset = "0x236CD0C", VA = "0x236CD0C")]
		private set
		{
		}
	}

	[Token(Token = "0x60137B7")]
	[Address(RVA = "0x236CAE8", Offset = "0x236CAE8", VA = "0x236CAE8")]
	public AwardItemInfo()
	{
	}

	[Token(Token = "0x60137B8")]
	[Address(RVA = "0x236CB6C", Offset = "0x236CB6C", VA = "0x236CB6C")]
	public AwardItemInfo(uint id, uint num, EInventory.AwardType type, uint max_num = 0u, uint expire = 0u)
	{
	}

	[Token(Token = "0x60137C9")]
	[Address(RVA = "0x236D6E4", Offset = "0x236D6E4", VA = "0x236D6E4")]
	public static implicit operator AwardItemInfo(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x60137CA")]
	[Address(RVA = "0x236CD6C", Offset = "0x236CD6C", VA = "0x236CD6C")]
	private static void FindIcon(AwardItemInfo info)
	{
	}
}
