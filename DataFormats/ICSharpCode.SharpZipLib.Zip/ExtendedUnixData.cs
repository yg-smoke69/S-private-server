using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C0B")]
public class ExtendedUnixData : _Attribute
{
	[Token(Token = "0x2003C0C")]
	public enum Flags : byte
	{
		[Token(Token = "0x40199E5")]
		ModificationTime = 1,
		[Token(Token = "0x40199E6")]
		AccessTime = 2,
		[Token(Token = "0x40199E7")]
		CreateTime = 4
	}

	[Token(Token = "0x40199E0")]
	[FieldOffset(Offset = "0x8")]
	private Flags _flags;

	[Token(Token = "0x40199E1")]
	[FieldOffset(Offset = "0x10")]
	private DateTime _modificationTime;

	[Token(Token = "0x40199E2")]
	[FieldOffset(Offset = "0x20")]
	private DateTime _lastAccessTime;

	[Token(Token = "0x40199E3")]
	[FieldOffset(Offset = "0x30")]
	private DateTime _createTime;

	[Token(Token = "0x1700195C")]
	public short TagID
	{
		[Token(Token = "0x6017F9B")]
		[Address(RVA = "0xA26B70", Offset = "0xA26B70", VA = "0xA26B70", Slot = "4")]
		get
		{
			return default(short);
		}
	}

	[Token(Token = "0x1700195D")]
	public DateTime ModificationTime
	{
		[Token(Token = "0x6017F9F")]
		[Address(RVA = "0xA27B90", Offset = "0xA27B90", VA = "0xA27B90")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FA0")]
		[Address(RVA = "0xA27BA0", Offset = "0xA27BA0", VA = "0xA27BA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700195E")]
	public DateTime AccessTime
	{
		[Token(Token = "0x6017FA1")]
		[Address(RVA = "0xA27C8C", Offset = "0xA27C8C", VA = "0xA27C8C")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FA2")]
		[Address(RVA = "0xA27C9C", Offset = "0xA27C9C", VA = "0xA27C9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700195F")]
	public DateTime CreateTime
	{
		[Token(Token = "0x6017FA3")]
		[Address(RVA = "0xA27D88", Offset = "0xA27D88", VA = "0xA27D88")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FA4")]
		[Address(RVA = "0xA27D98", Offset = "0xA27D98", VA = "0xA27D98")]
		set
		{
		}
	}

	[Token(Token = "0x17001960")]
	private Flags Include
	{
		[Token(Token = "0x6017FA5")]
		[Address(RVA = "0xA27E84", Offset = "0xA27E84", VA = "0xA27E84")]
		get
		{
			return default(Flags);
		}
		[Token(Token = "0x6017FA6")]
		[Address(RVA = "0xA27E8C", Offset = "0xA27E8C", VA = "0xA27E8C")]
		set
		{
		}
	}

	[Token(Token = "0x6017F9A")]
	[Address(RVA = "0xA26AB8", Offset = "0xA26AB8", VA = "0xA26AB8")]
	public ExtendedUnixData()
	{
	}

	[Token(Token = "0x6017F9C")]
	[Address(RVA = "0xA26B78", Offset = "0xA26B78", VA = "0xA26B78", Slot = "5")]
	public void SetData(byte[] data, int index, int count)
	{
	}

	[Token(Token = "0x6017F9D")]
	[Address(RVA = "0xA2734C", Offset = "0xA2734C", VA = "0xA2734C", Slot = "6")]
	public byte[] GetData()
	{
		return null;
	}

	[Token(Token = "0x6017F9E")]
	[Address(RVA = "0xA27A0C", Offset = "0xA27A0C", VA = "0xA27A0C")]
	public static bool IsValidValue(DateTime value)
	{
		return default(bool);
	}
}
