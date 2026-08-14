using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2000095")]
public class ActiveSkillData : CSVBaseData
{
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CSkillID_003Ek__BackingField;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0xC")]
	private float _003CCastingTime_003Ek__BackingField;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x10")]
	private float[] m_KeepingTimes;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x14")]
	private float _003CCDTime_003Ek__BackingField;

	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x18")]
	private bool _003CCanInterrupt_003Ek__BackingField;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x19")]
	private bool _003CKeepAlways_003Ek__BackingField;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x1C")]
	private float _003CCancelSkillDelayTime_003Ek__BackingField;

	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x20")]
	private float _003CDragButton_003Ek__BackingField;

	[Token(Token = "0x17000089")]
	public uint SkillID
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x14B8A84", Offset = "0x14B8A84", VA = "0x14B8A84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x14B8A8C", Offset = "0x14B8A8C", VA = "0x14B8A8C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public float CastingTime
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x14B8A94", Offset = "0x14B8A94", VA = "0x14B8A94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x14B8A9C", Offset = "0x14B8A9C", VA = "0x14B8A9C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	public int PhaseCount
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x14B8AA4", Offset = "0x14B8AA4", VA = "0x14B8AA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700008C")]
	public float ShowSkillCD
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x14B8B14", Offset = "0x14B8B14", VA = "0x14B8B14")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700008D")]
	public float CDTime
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x14B8B94", Offset = "0x14B8B94", VA = "0x14B8B94")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x14B8C70", Offset = "0x14B8C70", VA = "0x14B8C70")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008E")]
	public bool CanInterrupt
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x14B8C78", Offset = "0x14B8C78", VA = "0x14B8C78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x14B8C80", Offset = "0x14B8C80", VA = "0x14B8C80")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008F")]
	public bool KeepAlways
	{
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x14B8C88", Offset = "0x14B8C88", VA = "0x14B8C88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x14B8C90", Offset = "0x14B8C90", VA = "0x14B8C90")]
		private set
		{
		}
	}

	[Token(Token = "0x17000090")]
	public float CancelSkillDelayTime
	{
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x14B8C98", Offset = "0x14B8C98", VA = "0x14B8C98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x14B8CA0", Offset = "0x14B8CA0", VA = "0x14B8CA0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000091")]
	public float DragButton
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x14B8CA8", Offset = "0x14B8CA8", VA = "0x14B8CA8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x14B8CB0", Offset = "0x14B8CB0", VA = "0x14B8CB0")]
		private set
		{
		}
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x14B8A00", Offset = "0x14B8A00", VA = "0x14B8A00")]
	public ActiveSkillData()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x14B8CB8", Offset = "0x14B8CB8", VA = "0x14B8CB8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x14B8B9C", Offset = "0x14B8B9C", VA = "0x14B8B9C")]
	public float GetKeepingTime(int phase)
	{
		return default(float);
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x14B8D34", Offset = "0x14B8D34", VA = "0x14B8D34")]
	public float GetTotalKeepingTime()
	{
		return default(float);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x14B8E20", Offset = "0x14B8E20", VA = "0x14B8E20", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x14B9064", Offset = "0x14B9064", VA = "0x14B9064")]
	public ActiveSkillData DeepClone()
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x14B934C", Offset = "0x14B934C", VA = "0x14B934C")]
	public void SetCDTime(float time)
	{
	}
}
