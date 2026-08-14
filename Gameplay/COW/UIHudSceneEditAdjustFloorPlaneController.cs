using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002324")]
public class UIHudSceneEditAdjustFloorPlaneController : UIBaseController
{
	[Token(Token = "0x400DB06")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsSubPanelOpen;

	[Token(Token = "0x400DB07")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSceneEditAdjustFloorPlaneView m_View;

	[Token(Token = "0x400DB08")]
	private const string IconActive = "UI_Customize_location_icon3";

	[Token(Token = "0x400DB09")]
	private const string IconInActive = "UI_Customize_location_icon2";

	[Token(Token = "0x400DB0A")]
	[FieldOffset(Offset = "0x30")]
	private float mLastPressTime;

	[Token(Token = "0x600C2C6")]
	[Address(RVA = "0x1C52FC4", Offset = "0x1C52FC4", VA = "0x1C52FC4")]
	public UIHudSceneEditAdjustFloorPlaneController()
	{
	}

	[Token(Token = "0x600C2C7")]
	[Address(RVA = "0x1C53048", Offset = "0x1C53048", VA = "0x1C53048")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2C8")]
	[Address(RVA = "0x1C530EC", Offset = "0x1C530EC", VA = "0x1C530EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2C9")]
	[Address(RVA = "0x1C53400", Offset = "0x1C53400", VA = "0x1C53400")]
	private void Update()
	{
	}

	[Token(Token = "0x600C2CA")]
	[Address(RVA = "0x1C5397C", Offset = "0x1C5397C", VA = "0x1C5397C")]
	private void OnBtnIcon()
	{
	}

	[Token(Token = "0x600C2CB")]
	[Address(RVA = "0x1C5371C", Offset = "0x1C5371C", VA = "0x1C5371C")]
	private void OnBtnMoveUp()
	{
	}

	[Token(Token = "0x600C2CC")]
	[Address(RVA = "0x1C5384C", Offset = "0x1C5384C", VA = "0x1C5384C")]
	private void OnBtnMoveDown()
	{
	}

	[Token(Token = "0x600C2CD")]
	[Address(RVA = "0x1C53AE8", Offset = "0x1C53AE8", VA = "0x1C53AE8")]
	private void OnEnableFloorAdjust(object[] data)
	{
	}

	[Token(Token = "0x600C2CE")]
	[Address(RVA = "0x1C53DA8", Offset = "0x1C53DA8", VA = "0x1C53DA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
