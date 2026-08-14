using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C0D")]
public class NTTaggedData : _Attribute
{
	[Token(Token = "0x40199E8")]
	[FieldOffset(Offset = "0x8")]
	private DateTime _lastAccessTime;

	[Token(Token = "0x40199E9")]
	[FieldOffset(Offset = "0x18")]
	private DateTime _lastModificationTime;

	[Token(Token = "0x40199EA")]
	[FieldOffset(Offset = "0x28")]
	private DateTime _createTime;

	[Token(Token = "0x17001961")]
	public short TagID
	{
		[Token(Token = "0x6017FA8")]
		[Address(RVA = "0xA27F90", Offset = "0xA27F90", VA = "0xA27F90", Slot = "4")]
		get
		{
			return default(short);
		}
	}

	[Token(Token = "0x17001962")]
	public DateTime LastModificationTime
	{
		[Token(Token = "0x6017FAC")]
		[Address(RVA = "0xA28B74", Offset = "0xA28B74", VA = "0xA28B74")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FAD")]
		[Address(RVA = "0xA28B84", Offset = "0xA28B84", VA = "0xA28B84")]
		set
		{
		}
	}

	[Token(Token = "0x17001963")]
	public DateTime CreateTime
	{
		[Token(Token = "0x6017FAE")]
		[Address(RVA = "0xA28C64", Offset = "0xA28C64", VA = "0xA28C64")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FAF")]
		[Address(RVA = "0xA28C74", Offset = "0xA28C74", VA = "0xA28C74")]
		set
		{
		}
	}

	[Token(Token = "0x17001964")]
	public DateTime LastAccessTime
	{
		[Token(Token = "0x6017FB0")]
		[Address(RVA = "0xA28D54", Offset = "0xA28D54", VA = "0xA28D54")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6017FB1")]
		[Address(RVA = "0xA28D64", Offset = "0xA28D64", VA = "0xA28D64")]
		set
		{
		}
	}

	[Token(Token = "0x6017FA7")]
	[Address(RVA = "0xA27E94", Offset = "0xA27E94", VA = "0xA27E94")]
	public NTTaggedData()
	{
	}

	[Token(Token = "0x6017FA9")]
	[Address(RVA = "0xA27F98", Offset = "0xA27F98", VA = "0xA27F98", Slot = "5")]
	public void SetData(byte[] data, int index, int count)
	{
	}

	[Token(Token = "0x6017FAA")]
	[Address(RVA = "0xA285C0", Offset = "0xA285C0", VA = "0xA285C0", Slot = "6")]
	public byte[] GetData()
	{
		return null;
	}

	[Token(Token = "0x6017FAB")]
	[Address(RVA = "0xA28A7C", Offset = "0xA28A7C", VA = "0xA28A7C")]
	public static bool IsValidValue(DateTime value)
	{
		return default(bool);
	}
}
