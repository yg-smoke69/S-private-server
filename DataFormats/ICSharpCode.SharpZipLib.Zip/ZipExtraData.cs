using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C0F")]
public sealed class ZipExtraData : _Attribute
{
	[Token(Token = "0x40199EB")]
	[FieldOffset(Offset = "0x8")]
	private int _index;

	[Token(Token = "0x40199EC")]
	[FieldOffset(Offset = "0xC")]
	private int _readValueStart;

	[Token(Token = "0x40199ED")]
	[FieldOffset(Offset = "0x10")]
	private int _readValueLength;

	[Token(Token = "0x40199EE")]
	[FieldOffset(Offset = "0x14")]
	private MemoryStream _newEntry;

	[Token(Token = "0x40199EF")]
	[FieldOffset(Offset = "0x18")]
	private byte[] _data;

	[Token(Token = "0x17001965")]
	public int Length
	{
		[Token(Token = "0x6017FB7")]
		[Address(RVA = "0xA2BAEC", Offset = "0xA2BAEC", VA = "0xA2BAEC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001966")]
	public int ValueLength
	{
		[Token(Token = "0x6017FBB")]
		[Address(RVA = "0xA2AE24", Offset = "0xA2AE24", VA = "0xA2AE24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001967")]
	public int CurrentReadIndex
	{
		[Token(Token = "0x6017FBC")]
		[Address(RVA = "0xA2BD84", Offset = "0xA2BD84", VA = "0xA2BD84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001968")]
	public int UnreadCount
	{
		[Token(Token = "0x6017FBD")]
		[Address(RVA = "0xA2B05C", Offset = "0xA2B05C", VA = "0xA2B05C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6017FB3")]
	[Address(RVA = "0xA2B8CC", Offset = "0xA2B8CC", VA = "0xA2B8CC")]
	public ZipExtraData()
	{
	}

	[Token(Token = "0x6017FB4")]
	[Address(RVA = "0xA2ACCC", Offset = "0xA2ACCC", VA = "0xA2ACCC")]
	public ZipExtraData(byte[] data)
	{
	}

	[Token(Token = "0x6017FB5")]
	[Address(RVA = "0xA2B96C", Offset = "0xA2B96C", VA = "0xA2B96C")]
	public byte[] GetEntryData()
	{
		return null;
	}

	[Token(Token = "0x6017FB6")]
	[Address(RVA = "0xA2B8EC", Offset = "0xA2B8EC", VA = "0xA2B8EC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6017FB8")]
	[Address(RVA = "0xA2BB10", Offset = "0xA2BB10", VA = "0xA2BB10")]
	public Stream GetStreamForTag(int tag)
	{
		return null;
	}

	[Token(Token = "0x6017FB9")]
	[Address(RVA = "0xA2BBC8", Offset = "0xA2BBC8", VA = "0xA2BBC8")]
	private ITaggedData GetData(short tag)
	{
		return null;
	}

	[Token(Token = "0x6017FBA")]
	[Address(RVA = "0xA2BC10", Offset = "0xA2BC10", VA = "0xA2BC10")]
	private static ITaggedData Create(short tag, byte[] data, int offset, int count)
	{
		return null;
	}

	[Token(Token = "0x6017FBE")]
	[Address(RVA = "0xA2AD50", Offset = "0xA2AD50", VA = "0xA2AD50")]
	public bool Find(int headerID)
	{
		return default(bool);
	}

	[Token(Token = "0x6017FBF")]
	[Address(RVA = "0xA2BEE4", Offset = "0xA2BEE4", VA = "0xA2BEE4")]
	public void AddEntry(ITaggedData taggedData)
	{
	}

	[Token(Token = "0x6017FC0")]
	[Address(RVA = "0xA2C098", Offset = "0xA2C098", VA = "0xA2C098")]
	public void AddEntry(int headerID, byte[] fieldData)
	{
	}

	[Token(Token = "0x6017FC1")]
	[Address(RVA = "0xA2C4B8", Offset = "0xA2C4B8", VA = "0xA2C4B8")]
	public void StartNewEntry()
	{
	}

	[Token(Token = "0x6017FC2")]
	[Address(RVA = "0xA2C528", Offset = "0xA2C528", VA = "0xA2C528")]
	public void AddNewEntry(int headerID)
	{
	}

	[Token(Token = "0x6017FC3")]
	[Address(RVA = "0xA2C57C", Offset = "0xA2C57C", VA = "0xA2C57C")]
	public void AddData(byte data)
	{
	}

	[Token(Token = "0x6017FC4")]
	[Address(RVA = "0xA2C5B8", Offset = "0xA2C5B8", VA = "0xA2C5B8")]
	public void AddData(byte[] data)
	{
	}

	[Token(Token = "0x6017FC5")]
	[Address(RVA = "0xA2C6A8", Offset = "0xA2C6A8", VA = "0xA2C6A8")]
	public void AddLeShort(int toAdd)
	{
	}

	[Token(Token = "0x6017FC6")]
	[Address(RVA = "0xA2C714", Offset = "0xA2C714", VA = "0xA2C714")]
	public void AddLeInt(int toAdd)
	{
	}

	[Token(Token = "0x6017FC7")]
	[Address(RVA = "0xA2C73C", Offset = "0xA2C73C", VA = "0xA2C73C")]
	public void AddLeLong(long toAdd)
	{
	}

	[Token(Token = "0x6017FC8")]
	[Address(RVA = "0xA2C2F8", Offset = "0xA2C2F8", VA = "0xA2C2F8")]
	public bool Delete(int headerID)
	{
		return default(bool);
	}

	[Token(Token = "0x6017FC9")]
	[Address(RVA = "0xA2AE2C", Offset = "0xA2AE2C", VA = "0xA2AE2C")]
	public long ReadLong()
	{
		return default(long);
	}

	[Token(Token = "0x6017FCA")]
	[Address(RVA = "0xA2AE60", Offset = "0xA2AE60", VA = "0xA2AE60")]
	public int ReadInt()
	{
		return default(int);
	}

	[Token(Token = "0x6017FCB")]
	[Address(RVA = "0xA2AF94", Offset = "0xA2AF94", VA = "0xA2AF94")]
	public int ReadShort()
	{
		return default(int);
	}

	[Token(Token = "0x6017FCC")]
	[Address(RVA = "0xA2B13C", Offset = "0xA2B13C", VA = "0xA2B13C")]
	public int ReadByte()
	{
		return default(int);
	}

	[Token(Token = "0x6017FCD")]
	[Address(RVA = "0xA2B038", Offset = "0xA2B038", VA = "0xA2B038")]
	public void Skip(int amount)
	{
	}

	[Token(Token = "0x6017FCE")]
	[Address(RVA = "0xA2C780", Offset = "0xA2C780", VA = "0xA2C780")]
	private void ReadCheck(int length)
	{
	}

	[Token(Token = "0x6017FCF")]
	[Address(RVA = "0xA2BD8C", Offset = "0xA2BD8C", VA = "0xA2BD8C")]
	private int ReadShortInternal()
	{
		return default(int);
	}

	[Token(Token = "0x6017FD0")]
	[Address(RVA = "0xA2C414", Offset = "0xA2C414", VA = "0xA2C414")]
	private void SetShort(ref int index, int source)
	{
	}

	[Token(Token = "0x6017FD1")]
	[Address(RVA = "0xA2C900", Offset = "0xA2C900", VA = "0xA2C900", Slot = "4")]
	public void Dispose()
	{
	}
}
