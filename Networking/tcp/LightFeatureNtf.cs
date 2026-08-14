using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C55")]
public class LightFeatureNtf
{
	[Token(Token = "0x400B44E")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cfeature_name_003Ek__BackingField;

	[Token(Token = "0x400B44F")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _003Cfeature_data_003Ek__BackingField;

	[Token(Token = "0x400B450")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cdata_len_003Ek__BackingField;

	[Token(Token = "0x400B451")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cdata_crc_003Ek__BackingField;

	[Token(Token = "0x170009FA")]
	public string feature_name
	{
		[Token(Token = "0x60082CD")]
		[Address(RVA = "0x33EC2E4", Offset = "0x33EC2E4", VA = "0x33EC2E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082CE")]
		[Address(RVA = "0x33EC2DC", Offset = "0x33EC2DC", VA = "0x33EC2DC")]
		set
		{
		}
	}

	[Token(Token = "0x170009FB")]
	public byte[] feature_data
	{
		[Token(Token = "0x60082CF")]
		[Address(RVA = "0x33EC2EC", Offset = "0x33EC2EC", VA = "0x33EC2EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082D0")]
		[Address(RVA = "0x33EC2F4", Offset = "0x33EC2F4", VA = "0x33EC2F4")]
		set
		{
		}
	}

	[Token(Token = "0x170009FC")]
	public uint data_len
	{
		[Token(Token = "0x60082D1")]
		[Address(RVA = "0x33EC2FC", Offset = "0x33EC2FC", VA = "0x33EC2FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082D2")]
		[Address(RVA = "0x33EC304", Offset = "0x33EC304", VA = "0x33EC304")]
		set
		{
		}
	}

	[Token(Token = "0x170009FD")]
	public uint data_crc
	{
		[Token(Token = "0x60082D3")]
		[Address(RVA = "0x33EC30C", Offset = "0x33EC30C", VA = "0x33EC30C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082D4")]
		[Address(RVA = "0x33EC314", Offset = "0x33EC314", VA = "0x33EC314")]
		set
		{
		}
	}

	[Token(Token = "0x60082CC")]
	[Address(RVA = "0x33EC23C", Offset = "0x33EC23C", VA = "0x33EC23C")]
	public LightFeatureNtf()
	{
	}
}
