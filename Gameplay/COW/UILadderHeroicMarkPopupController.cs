using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002157")]
public class UILadderHeroicMarkPopupController : UIPopupWindowController
{
	[Token(Token = "0x400D15E")]
	[FieldOffset(Offset = "0x48")]
	private UILadderHeroicMarkPopupView m_View;

	[Token(Token = "0x400D15F")]
	private const string ANIM_END = "AnimEnd";

	[Token(Token = "0x400D160")]
	private const string ANIM_FIRST = "FX_UI_LaddeHeroicMarkPopupFirst";

	[Token(Token = "0x400D161")]
	private const string ANIM_LEVELUP = "FX_UI_LaddeHeroicMarkPopupLevelUp";

	[Token(Token = "0x400D162")]
	private const string ANIM_MASTER_LEVELUP = "FX_UI_LaddeHeroicMarkPopup03";

	[Token(Token = "0x400D163")]
	[FieldOffset(Offset = "0x4C")]
	private bool EnableSkip;

	[Token(Token = "0x600B007")]
	[Address(RVA = "0x1AE5B10", Offset = "0x1AE5B10", VA = "0x1AE5B10")]
	public UILadderHeroicMarkPopupController()
	{
	}

	[Token(Token = "0x600B008")]
	[Address(RVA = "0x1AE5B18", Offset = "0x1AE5B18", VA = "0x1AE5B18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B009")]
	[Address(RVA = "0x1AE5BBC", Offset = "0x1AE5BBC", VA = "0x1AE5BBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B00A")]
	[Address(RVA = "0x1AE5E04", Offset = "0x1AE5E04", VA = "0x1AE5E04", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B00B")]
	[Address(RVA = "0x1AE5FAC", Offset = "0x1AE5FAC", VA = "0x1AE5FAC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B00C")]
	[Address(RVA = "0x1AE60E0", Offset = "0x1AE60E0", VA = "0x1AE60E0")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600B00D")]
	[Address(RVA = "0x1AE6150", Offset = "0x1AE6150", VA = "0x1AE6150")]
	public void PlayFirstMasterAnim(EHeroicMarkType t, uint valAfter)
	{
	}

	[Token(Token = "0x600B00E")]
	[Address(RVA = "0x1AE6444", Offset = "0x1AE6444", VA = "0x1AE6444")]
	public void PlayAnim(EHeroicMarkType t, uint valBefore, uint valAfter)
	{
	}

	[Token(Token = "0x600B00F")]
	[Address(RVA = "0x1AE6B54", Offset = "0x1AE6B54", VA = "0x1AE6B54")]
	private void OnAnimEvtOccur(object[] data)
	{
	}

	[Token(Token = "0x600B010")]
	[Address(RVA = "0x1AE6D14", Offset = "0x1AE6D14", VA = "0x1AE6D14", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600B011")]
	[Address(RVA = "0x1AE6D6C", Offset = "0x1AE6D6C", VA = "0x1AE6D6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B012")]
	[Address(RVA = "0x1AE6D74", Offset = "0x1AE6D74", VA = "0x1AE6D74")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B013")]
	[Address(RVA = "0x1AE6D7C", Offset = "0x1AE6D7C", VA = "0x1AE6D7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B014")]
	[Address(RVA = "0x1AE6D84", Offset = "0x1AE6D84", VA = "0x1AE6D84")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
