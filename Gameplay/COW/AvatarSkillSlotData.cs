using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20000B0")]
public class AvatarSkillSlotData : CSVBaseData
{
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x0")]
	public static string DEFAULTREGIONNAME;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x8")]
	private string pKey;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0xC")]
	private List<SlotCostInfo> m_SlotInfoList;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x10")]
	private uint _003CAvatarID_003Ek__BackingField;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x14")]
	private string _003CAvatarName_003Ek__BackingField;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x18")]
	private string _003CRegion_003Ek__BackingField;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x1C")]
	private int _003CSkillSlot1GemsCost_003Ek__BackingField;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x20")]
	private int _003CSkillSlot1CoinCost_003Ek__BackingField;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x24")]
	private int _003CSkillSlot2GemsCost_003Ek__BackingField;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x28")]
	private int _003CSkillSlot2CoinCost_003Ek__BackingField;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x2C")]
	private int _003CSkillSlot3GemsCost_003Ek__BackingField;

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x30")]
	private int _003CSkillSlot3CoinCost_003Ek__BackingField;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x34")]
	private int _003CSkillSlot4GemsCost_003Ek__BackingField;

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x38")]
	private int _003CSkillSlot4CoinCost_003Ek__BackingField;

	[Token(Token = "0x170000E4")]
	public uint AvatarID
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x235F774", Offset = "0x235F774", VA = "0x235F774")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x235F77C", Offset = "0x235F77C", VA = "0x235F77C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E5")]
	public string AvatarName
	{
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x235F784", Offset = "0x235F784", VA = "0x235F784")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x235F78C", Offset = "0x235F78C", VA = "0x235F78C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public string Region
	{
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x235F794", Offset = "0x235F794", VA = "0x235F794")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x235F79C", Offset = "0x235F79C", VA = "0x235F79C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E7")]
	public int SkillSlot1GemsCost
	{
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x235F7A4", Offset = "0x235F7A4", VA = "0x235F7A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x235F7AC", Offset = "0x235F7AC", VA = "0x235F7AC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E8")]
	public int SkillSlot1CoinCost
	{
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x235F7B4", Offset = "0x235F7B4", VA = "0x235F7B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x235F7BC", Offset = "0x235F7BC", VA = "0x235F7BC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E9")]
	public int SkillSlot2GemsCost
	{
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x235F7C4", Offset = "0x235F7C4", VA = "0x235F7C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x235F7CC", Offset = "0x235F7CC", VA = "0x235F7CC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000EA")]
	public int SkillSlot2CoinCost
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x235F7D4", Offset = "0x235F7D4", VA = "0x235F7D4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x235F7DC", Offset = "0x235F7DC", VA = "0x235F7DC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000EB")]
	public int SkillSlot3GemsCost
	{
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x235F7E4", Offset = "0x235F7E4", VA = "0x235F7E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x235F7EC", Offset = "0x235F7EC", VA = "0x235F7EC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000EC")]
	public int SkillSlot3CoinCost
	{
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x235F7F4", Offset = "0x235F7F4", VA = "0x235F7F4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x235F7FC", Offset = "0x235F7FC", VA = "0x235F7FC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000ED")]
	public int SkillSlot4GemsCost
	{
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x235F804", Offset = "0x235F804", VA = "0x235F804")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x235F80C", Offset = "0x235F80C", VA = "0x235F80C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000EE")]
	public int SkillSlot4CoinCost
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x235F814", Offset = "0x235F814", VA = "0x235F814")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x235F81C", Offset = "0x235F81C", VA = "0x235F81C")]
		private set
		{
		}
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x235F674", Offset = "0x235F674", VA = "0x235F674")]
	public AvatarSkillSlotData()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x235F824", Offset = "0x235F824", VA = "0x235F824", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x235F87C", Offset = "0x235F87C", VA = "0x235F87C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x235FEB8", Offset = "0x235FEB8", VA = "0x235FEB8")]
	public int GetSlotCost(int slotIndex, EInventory.CurrencyType currencyType)
	{
		return default(int);
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x235FC30", Offset = "0x235FC30", VA = "0x235FC30")]
	private void ProcessSlotInfo()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x2360090", Offset = "0x2360090", VA = "0x2360090")]
	public List<SlotCostInfo> GetSlotInfo()
	{
		return null;
	}
}
