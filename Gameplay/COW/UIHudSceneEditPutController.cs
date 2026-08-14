using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002340")]
public class UIHudSceneEditPutController : UIBaseController
{
	[Token(Token = "0x400DB9F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditPutView m_View;

	[Token(Token = "0x400DBA0")]
	[FieldOffset(Offset = "0x2C")]
	private float mLastPutDownTime;

	[Token(Token = "0x400DBA1")]
	private const string ENABLE_PUT_ICON = "UI_Customize_Confirm_icon";

	[Token(Token = "0x400DBA2")]
	private const string DISABLE_PUT_ICON = "UI_Customize_Canot_icon";

	[Token(Token = "0x400DBA3")]
	[FieldOffset(Offset = "0x30")]
	private bool m_CanPutDown;

	[Token(Token = "0x400DBA4")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsRotating;

	[Token(Token = "0x400DBA5")]
	[FieldOffset(Offset = "0x34")]
	private float m_LastRotateStartTime;

	[Token(Token = "0x600C408")]
	[Address(RVA = "0x24EC774", Offset = "0x24EC774", VA = "0x24EC774")]
	public UIHudSceneEditPutController()
	{
	}

	[Token(Token = "0x600C409")]
	[Address(RVA = "0x24EC800", Offset = "0x24EC800", VA = "0x24EC800")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C40A")]
	[Address(RVA = "0x24EC8A4", Offset = "0x24EC8A4", VA = "0x24EC8A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C40B")]
	[Address(RVA = "0x24ECD38", Offset = "0x24ECD38", VA = "0x24ECD38", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C40C")]
	[Address(RVA = "0x24ECE6C", Offset = "0x24ECE6C", VA = "0x24ECE6C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C40D")]
	[Address(RVA = "0x24ED0D0", Offset = "0x24ED0D0", VA = "0x24ED0D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600C40E")]
	[Address(RVA = "0x24ED274", Offset = "0x24ED274", VA = "0x24ED274")]
	private bool CheckPutCooldown()
	{
		return default(bool);
	}

	[Token(Token = "0x600C40F")]
	[Address(RVA = "0x24ED314", Offset = "0x24ED314", VA = "0x24ED314")]
	private void OnBtnPut()
	{
	}

	[Token(Token = "0x600C410")]
	[Address(RVA = "0x24ED5AC", Offset = "0x24ED5AC", VA = "0x24ED5AC")]
	private void OnBtnRotate(GameObject obj)
	{
	}

	[Token(Token = "0x600C411")]
	[Address(RVA = "0x24ED844", Offset = "0x24ED844", VA = "0x24ED844")]
	private void OnBtnRotatePress(GameObject obj, bool isPressed)
	{
	}

	[Token(Token = "0x600C412")]
	[Address(RVA = "0x24EDA8C", Offset = "0x24EDA8C", VA = "0x24EDA8C")]
	private void OnBtnCancel()
	{
	}

	[Token(Token = "0x600C413")]
	[Address(RVA = "0x24EDD80", Offset = "0x24EDD80", VA = "0x24EDD80")]
	private void OnShowPutDown(object[] data)
	{
	}

	[Token(Token = "0x600C414")]
	[Address(RVA = "0x24EDE78", Offset = "0x24EDE78", VA = "0x24EDE78")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600C415")]
	[Address(RVA = "0x24ECEF4", Offset = "0x24ECEF4", VA = "0x24ECEF4")]
	private void TutorialPutDownBoj()
	{
	}

	[Token(Token = "0x600C416")]
	[Address(RVA = "0x24EE08C", Offset = "0x24EE08C", VA = "0x24EE08C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C417")]
	[Address(RVA = "0x24EE094", Offset = "0x24EE094", VA = "0x24EE094")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C418")]
	[Address(RVA = "0x24EE09C", Offset = "0x24EE09C", VA = "0x24EE09C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
