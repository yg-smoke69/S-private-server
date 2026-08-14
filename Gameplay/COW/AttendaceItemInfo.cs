using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EA1")]
public class AttendaceItemInfo : _Attribute
{
	[Token(Token = "0x2002EA2")]
	public enum EAttendanceSignState
	{
		[Token(Token = "0x4011CD8")]
		UnSigned,
		[Token(Token = "0x4011CD9")]
		Signed,
		[Token(Token = "0x4011CDA")]
		NeedSign,
		[Token(Token = "0x4011CDB")]
		Claimed
	}

	[Token(Token = "0x4011CD4")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CAttendaceItemID_003Ek__BackingField;

	[Token(Token = "0x4011CD5")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CSignState_003Ek__BackingField;

	[Token(Token = "0x4011CD6")]
	[FieldOffset(Offset = "0x10")]
	private List<AwardItemInfo> m_AwardInfoList;

	[Token(Token = "0x17001440")]
	public uint AttendaceItemID
	{
		[Token(Token = "0x60137CC")]
		[Address(RVA = "0x14CEAD0", Offset = "0x14CEAD0", VA = "0x14CEAD0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137CD")]
		[Address(RVA = "0x14CEAD8", Offset = "0x14CEAD8", VA = "0x14CEAD8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001441")]
	public bool Signed
	{
		[Token(Token = "0x60137CE")]
		[Address(RVA = "0x14CEAE0", Offset = "0x14CEAE0", VA = "0x14CEAE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60137CF")]
		[Address(RVA = "0x14CEB4C", Offset = "0x14CEB4C", VA = "0x14CEB4C")]
		set
		{
		}
	}

	[Token(Token = "0x17001442")]
	public uint SignState
	{
		[Token(Token = "0x60137D0")]
		[Address(RVA = "0x14CEB44", Offset = "0x14CEB44", VA = "0x14CEB44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60137D1")]
		[Address(RVA = "0x14CEBE0", Offset = "0x14CEBE0", VA = "0x14CEBE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001443")]
	public List<AwardItemInfo> AwardInfoList
	{
		[Token(Token = "0x60137D2")]
		[Address(RVA = "0x14CEBE8", Offset = "0x14CEBE8", VA = "0x14CEBE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60137CB")]
	[Address(RVA = "0x14CEA44", Offset = "0x14CEA44", VA = "0x14CEA44")]
	public AttendaceItemInfo()
	{
	}

	[Token(Token = "0x60137D3")]
	[Address(RVA = "0x14CEC40", Offset = "0x14CEC40", VA = "0x14CEC40")]
	public static implicit operator AttendaceItemInfo(AttendanceItem item)
	{
		return null;
	}

	[Token(Token = "0x60137D4")]
	[Address(RVA = "0x14CEE78", Offset = "0x14CEE78", VA = "0x14CEE78")]
	public static implicit operator AttendaceItemInfo(NewPlayerRewardItem item)
	{
		return null;
	}

	[Token(Token = "0x60137D5")]
	[Address(RVA = "0x14CF0B0", Offset = "0x14CF0B0", VA = "0x14CF0B0", Slot = "4")]
	public int CompareTo(AttendaceItemInfo other)
	{
		return default(int);
	}
}
