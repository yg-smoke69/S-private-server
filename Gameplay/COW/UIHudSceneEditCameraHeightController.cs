using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002325")]
internal class UIHudSceneEditCameraHeightController : UIBaseController
{
	[Token(Token = "0x400DB0B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditCameraHeightView m_View;

	[Token(Token = "0x400DB0C")]
	[FieldOffset(Offset = "0x2C")]
	private SceneEditAgent m_TargetAgent;

	[Token(Token = "0x600C2CF")]
	[Address(RVA = "0x1C541FC", Offset = "0x1C541FC", VA = "0x1C541FC")]
	public UIHudSceneEditCameraHeightController()
	{
	}

	[Token(Token = "0x600C2D0")]
	[Address(RVA = "0x1C54280", Offset = "0x1C54280", VA = "0x1C54280")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2D1")]
	[Address(RVA = "0x1C54324", Offset = "0x1C54324", VA = "0x1C54324")]
	public void Update()
	{
	}

	[Token(Token = "0x600C2D2")]
	[Address(RVA = "0x1C545FC", Offset = "0x1C545FC", VA = "0x1C545FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2D3")]
	[Address(RVA = "0x1C54808", Offset = "0x1C54808", VA = "0x1C54808", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C2D4")]
	[Address(RVA = "0x1C54408", Offset = "0x1C54408", VA = "0x1C54408")]
	private void UpdateHeightSlider()
	{
	}

	[Token(Token = "0x600C2D5")]
	[Address(RVA = "0x1C54A20", Offset = "0x1C54A20", VA = "0x1C54A20")]
	private void OnHeightSliderChange()
	{
	}

	[Token(Token = "0x600C2D6")]
	[Address(RVA = "0x1C54C18", Offset = "0x1C54C18", VA = "0x1C54C18")]
	private void OnHandleAgentCreate(object[] data)
	{
	}

	[Token(Token = "0x600C2D7")]
	[Address(RVA = "0x1C54CF4", Offset = "0x1C54CF4", VA = "0x1C54CF4")]
	private void OnHandleSliderDragFinish()
	{
	}

	[Token(Token = "0x600C2D8")]
	[Address(RVA = "0x1C54890", Offset = "0x1C54890", VA = "0x1C54890")]
	private void TutorialSlider()
	{
	}

	[Token(Token = "0x600C2D9")]
	[Address(RVA = "0x1C54E5C", Offset = "0x1C54E5C", VA = "0x1C54E5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C2DA")]
	[Address(RVA = "0x1C54E64", Offset = "0x1C54E64", VA = "0x1C54E64")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
