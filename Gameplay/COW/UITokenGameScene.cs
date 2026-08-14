using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003336")]
internal class UITokenGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x401383B")]
	[FieldOffset(Offset = "0x2D8")]
	private bool m_IntroInfoDone;

	[Token(Token = "0x401383C")]
	[FieldOffset(Offset = "0x2DC")]
	private List<UIHudTokenComboController> m_ConboCtrls;

	[Token(Token = "0x6015BB8")]
	[Address(RVA = "0x201D8EC", Offset = "0x201D8EC", VA = "0x201D8EC")]
	public UITokenGameScene()
	{
	}

	[Token(Token = "0x6015BB9")]
	[Address(RVA = "0x201D974", Offset = "0x201D974", VA = "0x201D974", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BBA")]
	[Address(RVA = "0x201DBDC", Offset = "0x201DBDC", VA = "0x201DBDC", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015BBB")]
	[Address(RVA = "0x201DE44", Offset = "0x201DE44", VA = "0x201DE44", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015BBC")]
	[Address(RVA = "0x201DE98", Offset = "0x201DE98", VA = "0x201DE98")]
	public void OnIntroInfoDone(object[] data)
	{
	}

	[Token(Token = "0x6015BBD")]
	[Address(RVA = "0x201DF00", Offset = "0x201DF00", VA = "0x201DF00")]
	public void OnIntroInfoShow(object[] data)
	{
	}

	[Token(Token = "0x6015BBE")]
	[Address(RVA = "0x201E084", Offset = "0x201E084", VA = "0x201E084")]
	private void OnShowCombo(object[] data)
	{
	}

	[Token(Token = "0x6015BBF")]
	[Address(RVA = "0x201E4C4", Offset = "0x201E4C4", VA = "0x201E4C4")]
	public void ShowLastPointTip(string tipContent)
	{
	}

	[Token(Token = "0x6015BC0")]
	[Address(RVA = "0x201E5F8", Offset = "0x201E5F8", VA = "0x201E5F8", Slot = "41")]
	protected override Type GetMatchEndShowHUD()
	{
		return null;
	}

	[Token(Token = "0x6015BC1")]
	[Address(RVA = "0x201E6D4", Offset = "0x201E6D4", VA = "0x201E6D4", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015BC2")]
	[Address(RVA = "0x201E7B0", Offset = "0x201E7B0", VA = "0x201E7B0")]
	private void _003COnIntroInfoShow_003Em__0()
	{
	}

	[Token(Token = "0x6015BC3")]
	[Address(RVA = "0x201E920", Offset = "0x201E920", VA = "0x201E920")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BC4")]
	[Address(RVA = "0x201E924", Offset = "0x201E924", VA = "0x201E924")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015BC5")]
	[Address(RVA = "0x201E928", Offset = "0x201E928", VA = "0x201E928")]
	public new void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015BC6")]
	[Address(RVA = "0x201E92C", Offset = "0x201E92C", VA = "0x201E92C")]
	public Type _003C_003EiFixBaseProxy_GetMatchEndShowHUD()
	{
		return null;
	}

	[Token(Token = "0x6015BC7")]
	[Address(RVA = "0x201E934", Offset = "0x201E934", VA = "0x201E934")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
