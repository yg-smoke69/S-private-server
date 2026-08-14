using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200232B")]
internal class UIHudSceneEditCurGameModeController : UIBaseController
{
	[Token(Token = "0x200232C")]
	private sealed class _003CRefreshCurMode_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DB33")]
		[FieldOffset(Offset = "0x8")]
		internal JPPGAJBAAKK sceneEditGame;

		[Token(Token = "0x400DB34")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudSceneEditCurGameModeController _0024this;

		[Token(Token = "0x600C319")]
		[Address(RVA = "0x1C5C370", Offset = "0x1C5C370", VA = "0x1C5C370")]
		public _003CRefreshCurMode_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C31A")]
		[Address(RVA = "0x1C5C3F0", Offset = "0x1C5C3F0", VA = "0x1C5C3F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DB32")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditCurGameModeView m_View;

	[Token(Token = "0x600C30F")]
	[Address(RVA = "0x1C5BAB8", Offset = "0x1C5BAB8", VA = "0x1C5BAB8")]
	public UIHudSceneEditCurGameModeController()
	{
	}

	[Token(Token = "0x600C310")]
	[Address(RVA = "0x1C5BB3C", Offset = "0x1C5BB3C", VA = "0x1C5BB3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C311")]
	[Address(RVA = "0x1C5BBE0", Offset = "0x1C5BBE0", VA = "0x1C5BBE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C312")]
	[Address(RVA = "0x1C5C114", Offset = "0x1C5C114", VA = "0x1C5C114")]
	private bool NeedShowModeHelpBtn(uint modeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600C313")]
	[Address(RVA = "0x1C5C188", Offset = "0x1C5C188", VA = "0x1C5C188")]
	private string HelpBtnMessage(uint modeID)
	{
		return null;
	}

	[Token(Token = "0x600C314")]
	[Address(RVA = "0x1C5C304", Offset = "0x1C5C304", VA = "0x1C5C304", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C315")]
	[Address(RVA = "0x1C5BCF0", Offset = "0x1C5BCF0", VA = "0x1C5BCF0")]
	private void RefreshCurMode()
	{
	}

	[Token(Token = "0x600C316")]
	[Address(RVA = "0x1C5C378", Offset = "0x1C5C378", VA = "0x1C5C378")]
	private void OnGameModeChange(object[] data)
	{
	}

	[Token(Token = "0x600C317")]
	[Address(RVA = "0x1C5C3E0", Offset = "0x1C5C3E0", VA = "0x1C5C3E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C318")]
	[Address(RVA = "0x1C5C3E8", Offset = "0x1C5C3E8", VA = "0x1C5C3E8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
