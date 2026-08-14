using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002326")]
internal class UIHudSceneEditCameraViewportController : UIBaseController
{
	[Token(Token = "0x400DB0D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditCameraViewportView m_View;

	[Token(Token = "0x400DB0E")]
	[FieldOffset(Offset = "0x2C")]
	private SceneEditAgent m_TargetAgent;

	[Token(Token = "0x600C2DB")]
	[Address(RVA = "0x1C55084", Offset = "0x1C55084", VA = "0x1C55084")]
	public UIHudSceneEditCameraViewportController()
	{
	}

	[Token(Token = "0x600C2DC")]
	[Address(RVA = "0x1C55108", Offset = "0x1C55108", VA = "0x1C55108")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2DD")]
	[Address(RVA = "0x1C551B0", Offset = "0x1C551B0", VA = "0x1C551B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2DE")]
	[Address(RVA = "0x1C5540C", Offset = "0x1C5540C", VA = "0x1C5540C")]
	private void OnHandleAgentCreate(object[] data)
	{
	}

	[Token(Token = "0x600C2DF")]
	[Address(RVA = "0x1C554E0", Offset = "0x1C554E0", VA = "0x1C554E0")]
	private void OnClickResetAngleBtn()
	{
	}

	[Token(Token = "0x600C2E0")]
	[Address(RVA = "0x1C556B0", Offset = "0x1C556B0", VA = "0x1C556B0")]
	private void OnClickCamProjection()
	{
	}

	[Token(Token = "0x600C2E1")]
	[Address(RVA = "0x1C557AC", Offset = "0x1C557AC", VA = "0x1C557AC")]
	private void OnCamProjectionChanged(object[] data)
	{
	}

	[Token(Token = "0x600C2E2")]
	[Address(RVA = "0x1C55940", Offset = "0x1C55940", VA = "0x1C55940")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
