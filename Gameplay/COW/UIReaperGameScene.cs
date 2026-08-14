using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200332D")]
internal class UIReaperGameScene : UIInGameScene
{
	[Token(Token = "0x401380D")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudReaperProgressBarController m_ScoreProgressBar;

	[Token(Token = "0x401380E")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudReaperTransformController m_ReaperTransformBtn;

	[Token(Token = "0x401380F")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudReaperHPBarController m_ReaperHPBar;

	[Token(Token = "0x6015B22")]
	[Address(RVA = "0x1AD0EFC", Offset = "0x1AD0EFC", VA = "0x1AD0EFC")]
	public UIReaperGameScene()
	{
	}

	[Token(Token = "0x6015B23")]
	[Address(RVA = "0x1AD0F80", Offset = "0x1AD0F80", VA = "0x1AD0F80", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015B24")]
	[Address(RVA = "0x1AD0FE4", Offset = "0x1AD0FE4", VA = "0x1AD0FE4", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B25")]
	[Address(RVA = "0x1AD1190", Offset = "0x1AD1190", VA = "0x1AD1190", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B26")]
	[Address(RVA = "0x1AD12C4", Offset = "0x1AD12C4", VA = "0x1AD12C4", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015B27")]
	[Address(RVA = "0x1AD13F8", Offset = "0x1AD13F8", VA = "0x1AD13F8")]
	public void OnEnterPregame()
	{
	}

	[Token(Token = "0x6015B28")]
	[Address(RVA = "0x1AD16D0", Offset = "0x1AD16D0", VA = "0x1AD16D0")]
	public void OnEnterFight()
	{
	}

	[Token(Token = "0x6015B29")]
	[Address(RVA = "0x1AD1C28", Offset = "0x1AD1C28", VA = "0x1AD1C28")]
	public void OnIntroEnd()
	{
	}

	[Token(Token = "0x6015B2A")]
	[Address(RVA = "0x1AD1C7C", Offset = "0x1AD1C7C", VA = "0x1AD1C7C")]
	public void OnFirstSecondScoreChange()
	{
	}

	[Token(Token = "0x6015B2B")]
	[Address(RVA = "0x1AD1EB8", Offset = "0x1AD1EB8", VA = "0x1AD1EB8")]
	public void OnSoulChange()
	{
	}

	[Token(Token = "0x6015B2C")]
	[Address(RVA = "0x1AD1F30", Offset = "0x1AD1F30", VA = "0x1AD1F30")]
	public void OnReaperHPChange(int oldV, int newV)
	{
	}

	[Token(Token = "0x6015B2D")]
	[Address(RVA = "0x1AD2058", Offset = "0x1AD2058", VA = "0x1AD2058")]
	public void OnReaperStateChange(bool toReaper = false, bool toNormal = false)
	{
	}

	[Token(Token = "0x6015B2E")]
	[Address(RVA = "0x1AD1B0C", Offset = "0x1AD1B0C", VA = "0x1AD1B0C")]
	public void OpenEquipSetSelection()
	{
	}

	[Token(Token = "0x6015B2F")]
	[Address(RVA = "0x1AD22C0", Offset = "0x1AD22C0", VA = "0x1AD22C0", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015B30")]
	[Address(RVA = "0x1AD239C", Offset = "0x1AD239C", VA = "0x1AD239C")]
	private void _003COnEnterPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015B31")]
	[Address(RVA = "0x1AD2460", Offset = "0x1AD2460", VA = "0x1AD2460")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015B32")]
	[Address(RVA = "0x1AD2468", Offset = "0x1AD2468", VA = "0x1AD2468")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B33")]
	[Address(RVA = "0x1AD2470", Offset = "0x1AD2470", VA = "0x1AD2470")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B34")]
	[Address(RVA = "0x1AD2478", Offset = "0x1AD2478", VA = "0x1AD2478")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B35")]
	[Address(RVA = "0x1AD2480", Offset = "0x1AD2480", VA = "0x1AD2480")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
