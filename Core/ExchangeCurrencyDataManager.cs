using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2002DDF")]
public class ExchangeCurrencyDataManager : SingletonModule<ExchangeCurrencyDataManager>
{
	[Token(Token = "0x2002DE0")]
	public enum EExchangeCurrencyType
	{
		[Token(Token = "0x40119AF")]
		NONE,
		[Token(Token = "0x40119B0")]
		ACTIVITYEXCHANGE,
		[Token(Token = "0x40119B1")]
		MALLEXCHANGE,
		[Token(Token = "0x40119B2")]
		WEBSITE
	}

	[Token(Token = "0x2002DE1")]
	public enum EExchangeCurrencySubType
	{
		[Token(Token = "0x40119B4")]
		NONE = 0,
		[Token(Token = "0x40119B5")]
		Rank = 5,
		[Token(Token = "0x40119B6")]
		Crystal = 6,
		[Token(Token = "0x40119B7")]
		Clan = 16
	}

	[Token(Token = "0x40119AD")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, ExchangeCurrencyDesc> m_ExchangeCurrencyDict;

	[Token(Token = "0x60133B1")]
	[Address(RVA = "0x320DA30", Offset = "0x320DA30", VA = "0x320DA30")]
	public ExchangeCurrencyDataManager()
	{
	}

	[Token(Token = "0x60133B2")]
	[Address(RVA = "0x320DAF4", Offset = "0x320DAF4", VA = "0x320DAF4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133B3")]
	[Address(RVA = "0x320DAF8", Offset = "0x320DAF8", VA = "0x320DAF8")]
	public void ProcessData(CSGetExchangeCurrencyAllDescRes res)
	{
	}

	[Token(Token = "0x60133B4")]
	[Address(RVA = "0x320DCC4", Offset = "0x320DCC4", VA = "0x320DCC4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133B5")]
	[Address(RVA = "0x320DD3C", Offset = "0x320DD3C", VA = "0x320DD3C")]
	public ExchangeCurrencyDesc GetExchangeCurrency(uint id)
	{
		return null;
	}
}
