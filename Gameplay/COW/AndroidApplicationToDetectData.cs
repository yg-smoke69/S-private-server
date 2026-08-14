using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200009A")]
public class AndroidApplicationToDetectData : CSVBaseData
{
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x8")]
	private int _003CID_003Ek__BackingField;

	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0xC")]
	private string _003CBundleIdentifier_003Ek__BackingField;

	[Token(Token = "0x17000092")]
	public int ID
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x14C54E0", Offset = "0x14C54E0", VA = "0x14C54E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x14C54E8", Offset = "0x14C54E8", VA = "0x14C54E8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000093")]
	public string BundleIdentifier
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x14C54F0", Offset = "0x14C54F0", VA = "0x14C54F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x14C54F8", Offset = "0x14C54F8", VA = "0x14C54F8")]
		private set
		{
		}
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x14C545C", Offset = "0x14C545C", VA = "0x14C545C")]
	public AndroidApplicationToDetectData()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x14C5500", Offset = "0x14C5500", VA = "0x14C5500", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x14C5558", Offset = "0x14C5558", VA = "0x14C5558", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
