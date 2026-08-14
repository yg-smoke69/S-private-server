using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C12")]
internal class ZipHelperStream : Stream
{
	[Token(Token = "0x40199F5")]
	[FieldOffset(Offset = "0x8")]
	private bool isOwner_;

	[Token(Token = "0x40199F6")]
	[FieldOffset(Offset = "0xC")]
	private Stream stream_;

	[Token(Token = "0x1700196E")]
	public bool IsStreamOwner
	{
		[Token(Token = "0x6017FE0")]
		[Address(RVA = "0xA2C9E8", Offset = "0xA2C9E8", VA = "0xA2C9E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017FE1")]
		[Address(RVA = "0xA279E0", Offset = "0xA279E0", VA = "0xA279E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700196F")]
	public override bool CanRead
	{
		[Token(Token = "0x6017FE2")]
		[Address(RVA = "0xA2C9F0", Offset = "0xA2C9F0", VA = "0xA2C9F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001970")]
	public override bool CanSeek
	{
		[Token(Token = "0x6017FE3")]
		[Address(RVA = "0xA2CA24", Offset = "0xA2CA24", VA = "0xA2CA24", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001971")]
	public override bool CanTimeout
	{
		[Token(Token = "0x6017FE4")]
		[Address(RVA = "0xA2CA58", Offset = "0xA2CA58", VA = "0xA2CA58", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001972")]
	public override long Length
	{
		[Token(Token = "0x6017FE5")]
		[Address(RVA = "0xA2CA8C", Offset = "0xA2CA8C", VA = "0xA2CA8C", Slot = "9")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001973")]
	public override long Position
	{
		[Token(Token = "0x6017FE6")]
		[Address(RVA = "0xA2CAC0", Offset = "0xA2CAC0", VA = "0xA2CAC0", Slot = "10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017FE7")]
		[Address(RVA = "0xA2CAF4", Offset = "0xA2CAF4", VA = "0xA2CAF4", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x17001974")]
	public override bool CanWrite
	{
		[Token(Token = "0x6017FE8")]
		[Address(RVA = "0xA2CB44", Offset = "0xA2CB44", VA = "0xA2CB44", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017FDE")]
	[Address(RVA = "0xA2C91C", Offset = "0xA2C91C", VA = "0xA2C91C")]
	public ZipHelperStream(string name)
	{
	}

	[Token(Token = "0x6017FDF")]
	[Address(RVA = "0xA2729C", Offset = "0xA2729C", VA = "0xA2729C")]
	public ZipHelperStream(Stream stream)
	{
	}

	[Token(Token = "0x6017FE9")]
	[Address(RVA = "0xA2CB78", Offset = "0xA2CB78", VA = "0xA2CB78", Slot = "16")]
	public override void Flush()
	{
	}

	[Token(Token = "0x6017FEA")]
	[Address(RVA = "0xA2CBAC", Offset = "0xA2CBAC", VA = "0xA2CBAC", Slot = "19")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6017FEB")]
	[Address(RVA = "0xA2CC04", Offset = "0xA2CC04", VA = "0xA2CC04", Slot = "20")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x6017FEC")]
	[Address(RVA = "0xA2CC54", Offset = "0xA2CC54", VA = "0xA2CC54", Slot = "17")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017FED")]
	[Address(RVA = "0xA2CCAC", Offset = "0xA2CCAC", VA = "0xA2CCAC", Slot = "21")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6017FEE")]
	[Address(RVA = "0xA2CD04", Offset = "0xA2CD04", VA = "0xA2CD04", Slot = "13")]
	public override void Close()
	{
	}

	[Token(Token = "0x6017FEF")]
	[Address(RVA = "0xA2CD40", Offset = "0xA2CD40", VA = "0xA2CD40")]
	private void WriteLocalHeader(ZipEntry entry, EntryPatchData patchData)
	{
	}

	[Token(Token = "0x6017FF0")]
	[Address(RVA = "0xA2D248", Offset = "0xA2D248", VA = "0xA2D248")]
	public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
	{
		return default(long);
	}

	[Token(Token = "0x6017FF1")]
	[Address(RVA = "0xA2D320", Offset = "0xA2D320", VA = "0xA2D320")]
	public void WriteZip64EndOfCentralDirectory(long noOfEntries, long sizeEntries, long centralDirOffset)
	{
	}

	[Token(Token = "0x6017FF2")]
	[Address(RVA = "0xA2D498", Offset = "0xA2D498", VA = "0xA2D498")]
	public void WriteEndOfCentralDirectory(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
	{
	}

	[Token(Token = "0x6017FF3")]
	[Address(RVA = "0xA2845C", Offset = "0xA2845C", VA = "0xA2845C")]
	public int ReadLEShort()
	{
		return default(int);
	}

	[Token(Token = "0x6017FF4")]
	[Address(RVA = "0xA27328", Offset = "0xA27328", VA = "0xA27328")]
	public int ReadLEInt()
	{
		return default(int);
	}

	[Token(Token = "0x6017FF5")]
	[Address(RVA = "0xA28580", Offset = "0xA28580", VA = "0xA28580")]
	public long ReadLELong()
	{
		return default(long);
	}

	[Token(Token = "0x6017FF6")]
	[Address(RVA = "0xA289CC", Offset = "0xA289CC", VA = "0xA289CC")]
	public void WriteLEShort(int value)
	{
	}

	[Token(Token = "0x6017FF7")]
	[Address(RVA = "0xA2D764", Offset = "0xA2D764", VA = "0xA2D764")]
	public void WriteLEUshort(ushort value)
	{
	}

	[Token(Token = "0x6017FF8")]
	[Address(RVA = "0xA279E8", Offset = "0xA279E8", VA = "0xA279E8")]
	public void WriteLEInt(int value)
	{
	}

	[Token(Token = "0x6017FF9")]
	[Address(RVA = "0xA2D7D0", Offset = "0xA2D7D0", VA = "0xA2D7D0")]
	public void WriteLEUint(uint value)
	{
	}

	[Token(Token = "0x6017FFA")]
	[Address(RVA = "0xA28A38", Offset = "0xA28A38", VA = "0xA28A38")]
	public void WriteLELong(long value)
	{
	}

	[Token(Token = "0x6017FFB")]
	[Address(RVA = "0xA2D7F8", Offset = "0xA2D7F8", VA = "0xA2D7F8")]
	public void WriteLEUlong(ulong value)
	{
	}

	[Token(Token = "0x6017FFC")]
	[Address(RVA = "0xA2D83C", Offset = "0xA2D83C", VA = "0xA2D83C")]
	public int WriteDataDescriptor(ZipEntry entry)
	{
		return default(int);
	}

	[Token(Token = "0x6017FFD")]
	[Address(RVA = "0xA2D9EC", Offset = "0xA2D9EC", VA = "0xA2D9EC")]
	public void ReadDataDescriptor(bool zip64, DescriptorData data)
	{
	}
}
