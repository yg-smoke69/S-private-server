using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200005D")]
internal enum SDKIAPTask
{
	[Token(Token = "0x400021F")]
	None,
	[Token(Token = "0x4000220")]
	ScanIAPInventory,
	[Token(Token = "0x4000221")]
	LoadIAPItems,
	[Token(Token = "0x4000222")]
	LoadRebateOptions,
	[Token(Token = "0x4000223")]
	LoadSomeIAPItems,
	[Token(Token = "0x4000224")]
	LoadSomeRebateOptions,
	[Token(Token = "0x4000225")]
	PurchaseProduct,
	[Token(Token = "0x4000226")]
	PurchaseRebateCard,
	[Token(Token = "0x4000227")]
	RedeemRebateOption,
	[Token(Token = "0x4000228")]
	LoadEventConfigs,
	[Token(Token = "0x4000229")]
	LoadEventIAPItems,
	[Token(Token = "0x400022A")]
	PurchaseEventProduct
}
