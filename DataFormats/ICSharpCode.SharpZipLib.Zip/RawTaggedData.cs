using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C0A")]
public class RawTaggedData : _Attribute
{
	[Token(Token = "0x40199DE")]
	[FieldOffset(Offset = "0x8")]
	private short _tag;

	[Token(Token = "0x40199DF")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _data;

	[Token(Token = "0x1700195A")]
	public short TagID
	{
		[Token(Token = "0x6017F94")]
		[Address(RVA = "0xA28E64", Offset = "0xA28E64", VA = "0xA28E64", Slot = "4")]
		get
		{
			return default(short);
		}
		[Token(Token = "0x6017F95")]
		[Address(RVA = "0xA28E6C", Offset = "0xA28E6C", VA = "0xA28E6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700195B")]
	public byte[] Data
	{
		[Token(Token = "0x6017F98")]
		[Address(RVA = "0xA28F78", Offset = "0xA28F78", VA = "0xA28F78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017F99")]
		[Address(RVA = "0xA28F80", Offset = "0xA28F80", VA = "0xA28F80")]
		set
		{
		}
	}

	[Token(Token = "0x6017F93")]
	[Address(RVA = "0xA28E44", Offset = "0xA28E44", VA = "0xA28E44")]
	public RawTaggedData(short tag)
	{
	}

	[Token(Token = "0x6017F96")]
	[Address(RVA = "0xA28E74", Offset = "0xA28E74", VA = "0xA28E74", Slot = "5")]
	public void SetData(byte[] data, int offset, int count)
	{
	}

	[Token(Token = "0x6017F97")]
	[Address(RVA = "0xA28F70", Offset = "0xA28F70", VA = "0xA28F70", Slot = "6")]
	public byte[] GetData()
	{
		return null;
	}
}
