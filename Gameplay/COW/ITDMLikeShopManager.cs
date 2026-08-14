using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000244")]
internal interface ITDMLikeShopManager
{
	[Token(Token = "0x6000B65")]
	TDMLikeShopConfigDataManager GetTDMLikeShopManager();

	[Token(Token = "0x6000B66")]
	void ShowInitialEquipSetsWindow();
}
