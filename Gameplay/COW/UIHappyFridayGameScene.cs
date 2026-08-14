using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200331C")]
internal class UIHappyFridayGameScene : UIRushingPetsGameScene
{
	[Token(Token = "0x40136FE")]
	[FieldOffset(Offset = "0x2DC")]
	private AudioResource curAudioResource;

	[Token(Token = "0x40136FF")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015930")]
	[Address(RVA = "0x16296A4", Offset = "0x16296A4", VA = "0x16296A4")]
	public UIHappyFridayGameScene()
	{
	}

	[Token(Token = "0x6015931")]
	[Address(RVA = "0x16296AC", Offset = "0x16296AC", VA = "0x16296AC", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015932")]
	[Address(RVA = "0x16297D4", Offset = "0x16297D4", VA = "0x16297D4", Slot = "44")]
	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015933")]
	[Address(RVA = "0x1629884", Offset = "0x1629884", VA = "0x1629884", Slot = "47")]
	public override void OpenSpeedUpHUD()
	{
	}

	[Token(Token = "0x6015934")]
	[Address(RVA = "0x16298D8", Offset = "0x16298D8", VA = "0x16298D8", Slot = "48")]
	public override void OpenJumpBtn()
	{
	}

	[Token(Token = "0x6015935")]
	[Address(RVA = "0x162998C", Offset = "0x162998C", VA = "0x162998C", Slot = "49")]
	public override void OpenMatchResult()
	{
	}

	[Token(Token = "0x6015936")]
	[Address(RVA = "0x1629AC0", Offset = "0x1629AC0", VA = "0x1629AC0", Slot = "50")]
	public override void OpenLevelEndShowUI(LLAHOLGIFFE msg)
	{
	}

	[Token(Token = "0x6015937")]
	[Address(RVA = "0x1629C9C", Offset = "0x1629C9C", VA = "0x1629C9C", Slot = "53")]
	protected override void OnNewPhase(object[] data)
	{
	}

	[Token(Token = "0x6015938")]
	[Address(RVA = "0x1629E60", Offset = "0x1629E60", VA = "0x1629E60", Slot = "54")]
	protected override void OpenIntroInfo()
	{
	}

	[Token(Token = "0x6015939")]
	[Address(RVA = "0x1629FEC", Offset = "0x1629FEC", VA = "0x1629FEC", Slot = "22")]
	protected override void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x601593A")]
	[Address(RVA = "0x162A048", Offset = "0x162A048", VA = "0x162A048")]
	private static void _003COpenIntroInfo_003Em__0()
	{
	}

	[Token(Token = "0x601593B")]
	[Address(RVA = "0x162A12C", Offset = "0x162A12C", VA = "0x162A12C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x601593C")]
	[Address(RVA = "0x162A134", Offset = "0x162A134", VA = "0x162A134")]
	public new ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601593D")]
	[Address(RVA = "0x162A13C", Offset = "0x162A13C", VA = "0x162A13C")]
	public void _003C_003EiFixBaseProxy_OpenSpeedUpHUD()
	{
	}

	[Token(Token = "0x601593E")]
	[Address(RVA = "0x162A144", Offset = "0x162A144", VA = "0x162A144")]
	public void _003C_003EiFixBaseProxy_OpenJumpBtn()
	{
	}

	[Token(Token = "0x601593F")]
	[Address(RVA = "0x162A14C", Offset = "0x162A14C", VA = "0x162A14C")]
	public void _003C_003EiFixBaseProxy_OpenMatchResult()
	{
	}

	[Token(Token = "0x6015940")]
	[Address(RVA = "0x162A154", Offset = "0x162A154", VA = "0x162A154")]
	public void _003C_003EiFixBaseProxy_OpenLevelEndShowUI(LLAHOLGIFFE P0)
	{
	}

	[Token(Token = "0x6015941")]
	[Address(RVA = "0x162A15C", Offset = "0x162A15C", VA = "0x162A15C")]
	public void _003C_003EiFixBaseProxy_OnNewPhase(object[] P0)
	{
	}

	[Token(Token = "0x6015942")]
	[Address(RVA = "0x162A164", Offset = "0x162A164", VA = "0x162A164")]
	public void _003C_003EiFixBaseProxy_OpenIntroInfo()
	{
	}

	[Token(Token = "0x6015943")]
	[Address(RVA = "0x162A16C", Offset = "0x162A16C", VA = "0x162A16C")]
	public new void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}
}
