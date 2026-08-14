using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200257E")]
public class UICommonGuideController : UIBaseController
{
	[Token(Token = "0x400E7FA")]
	[FieldOffset(Offset = "0x28")]
	private UICommonGuideView m_View;

	[Token(Token = "0x400E7FB")]
	[FieldOffset(Offset = "0x2C")]
	private UITutorialIndicatorCharacterController m_UICharacter;

	[Token(Token = "0x400E7FC")]
	[FieldOffset(Offset = "0x30")]
	private UITutorialIndicatorHandController m_UIHand;

	[Token(Token = "0x400E7FD")]
	private const float TextIntervalWithCircle = 85f;

	[Token(Token = "0x400E7FE")]
	private const float TextIntervalWithCharacter = 40f;

	[Token(Token = "0x400E7FF")]
	private const int DefaultCircleWidth = 100;

	[Token(Token = "0x400E800")]
	private const int DefaultRectWidth = 300;

	[Token(Token = "0x400E801")]
	private const int DefaultRectHeight = 100;

	[Token(Token = "0x400E802")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardGuideMaskController m_GuideMaskCtrl;

	[Token(Token = "0x400E803")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, Quaternion> m_ArrowQuaternionDict;

	[Token(Token = "0x400E804")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, Vector2> m_ArrowAnchorPixelOffetDict;

	[Token(Token = "0x400E805")]
	[FieldOffset(Offset = "0x40")]
	private CommonGuideSetting m_CommonGuideSetting;

	[Token(Token = "0x400E806")]
	[FieldOffset(Offset = "0x44")]
	private Transform m_BindWidgetTrans;

	[Token(Token = "0x400E807")]
	[FieldOffset(Offset = "0x48")]
	private UIButton m_BindBtn;

	[Token(Token = "0x400E808")]
	[FieldOffset(Offset = "0x4C")]
	private UIToggle m_BindToggle;

	[Token(Token = "0x400E809")]
	[FieldOffset(Offset = "0x50")]
	private EventDelegate m_TmpClickEvent;

	[Token(Token = "0x400E80A")]
	[FieldOffset(Offset = "0x54")]
	private float m_CachTextWidth;

	[Token(Token = "0x400E80B")]
	[FieldOffset(Offset = "0x58")]
	private float m_CachTextHeight;

	[Token(Token = "0x400E80C")]
	[FieldOffset(Offset = "0x5C")]
	private Side m_CachAnchorSide;

	[Token(Token = "0x400E80D")]
	[FieldOffset(Offset = "0x60")]
	private TutorialUIType m_CachHintType;

	[Token(Token = "0x400E80E")]
	[FieldOffset(Offset = "0x64")]
	private Action m_CloseAction;

	[Token(Token = "0x400E80F")]
	[FieldOffset(Offset = "0x68")]
	private UIWidget m_BindWidget;

	[Token(Token = "0x400E810")]
	[FieldOffset(Offset = "0x6C")]
	private uint DelayCallId;

	[Token(Token = "0x400E811")]
	[FieldOffset(Offset = "0x70")]
	private bool m_NeedFollowTarget;

	[Token(Token = "0x600DB26")]
	[Address(RVA = "0x2CDE950", Offset = "0x2CDE950", VA = "0x2CDE950")]
	public UICommonGuideController()
	{
	}

	[Token(Token = "0x600DB27")]
	[Address(RVA = "0x2CDEFB4", Offset = "0x2CDEFB4", VA = "0x2CDEFB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB28")]
	[Address(RVA = "0x2CDF05C", Offset = "0x2CDF05C", VA = "0x2CDF05C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB29")]
	[Address(RVA = "0x2CDF4B8", Offset = "0x2CDF4B8", VA = "0x2CDF4B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DB2A")]
	[Address(RVA = "0x2CDF5D4", Offset = "0x2CDF5D4", VA = "0x2CDF5D4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DB2B")]
	[Address(RVA = "0x2CDF64C", Offset = "0x2CDF64C", VA = "0x2CDF64C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600DB2C")]
	[Address(RVA = "0x2CDF6D8", Offset = "0x2CDF6D8", VA = "0x2CDF6D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600DB2D")]
	[Address(RVA = "0x2CDF128", Offset = "0x2CDF128", VA = "0x2CDF128")]
	public void Reset()
	{
	}

	[Token(Token = "0x600DB2E")]
	[Address(RVA = "0x2CDFE84", Offset = "0x2CDFE84", VA = "0x2CDFE84")]
	public void ShowGuideWithMask(UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, [Optional] List<EventDelegate> guideMaskAction, [Optional] Transform guideMaskContainer)
	{
	}

	[Token(Token = "0x600DB2F")]
	[Address(RVA = "0x2CE0F58", Offset = "0x2CE0F58", VA = "0x2CE0F58")]
	public void ShowGuideWithMask(UIButton bindBtn, UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, [Optional] List<EventDelegate> guideMaskAction, [Optional] Transform guideMaskContainer)
	{
	}

	[Token(Token = "0x600DB30")]
	[Address(RVA = "0x2CE1158", Offset = "0x2CE1158", VA = "0x2CE1158")]
	public void ShowGuide(UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, bool needFollowTarget = false)
	{
	}

	[Token(Token = "0x600DB31")]
	[Address(RVA = "0x2CE11F0", Offset = "0x2CE11F0", VA = "0x2CE11F0")]
	public void ShowGuide(UIToggle bindToogleNotBtn, UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, bool needFollowTarget = false)
	{
	}

	[Token(Token = "0x600DB32")]
	[Address(RVA = "0x2CE1294", Offset = "0x2CE1294", VA = "0x2CE1294")]
	public void ShowGuide(UIButton bindBtn, UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, bool needFollowTarget = false)
	{
	}

	[Token(Token = "0x600DB33")]
	[Address(RVA = "0x2CE1338", Offset = "0x2CE1338", VA = "0x2CE1338")]
	public void SetOnCloseCallback(Action callback)
	{
	}

	[Token(Token = "0x600DB34")]
	[Address(RVA = "0x2CE009C", Offset = "0x2CE009C", VA = "0x2CE009C")]
	private void InitGuideView(UIWidget bindWidget, CommonGuideSetting guideSetting, Side anchorSide, bool needFollowTarget = false)
	{
	}

	[Token(Token = "0x600DB35")]
	[Address(RVA = "0x2CE2CDC", Offset = "0x2CE2CDC", VA = "0x2CE2CDC")]
	public UIWidget GetClickWidget()
	{
		return null;
	}

	[Token(Token = "0x600DB36")]
	[Address(RVA = "0x2CE2D34", Offset = "0x2CE2D34", VA = "0x2CE2D34")]
	public void UpdateDepth(int newDepth)
	{
	}

	[Token(Token = "0x600DB37")]
	[Address(RVA = "0x2CE2E0C", Offset = "0x2CE2E0C", VA = "0x2CE2E0C")]
	public void UpdateGuideMaskDepth(int newDepth)
	{
	}

	[Token(Token = "0x600DB38")]
	[Address(RVA = "0x2CE2F8C", Offset = "0x2CE2F8C", VA = "0x2CE2F8C")]
	private bool CheckHintCharacterNeedShow(TutorialUIType hintType)
	{
		return default(bool);
	}

	[Token(Token = "0x600DB39")]
	[Address(RVA = "0x2CE1398", Offset = "0x2CE1398", VA = "0x2CE1398")]
	private void SetHintCharacterActive(bool active)
	{
	}

	[Token(Token = "0x600DB3A")]
	[Address(RVA = "0x2CE1594", Offset = "0x2CE1594", VA = "0x2CE1594")]
	private void ArrowRotateByDirection(Side anchorSide)
	{
	}

	[Token(Token = "0x600DB3B")]
	[Address(RVA = "0x2CDF828", Offset = "0x2CDF828", VA = "0x2CDF828")]
	private void UpdatePosition(Transform showTrans)
	{
	}

	[Token(Token = "0x600DB3C")]
	[Address(RVA = "0x2CE2038", Offset = "0x2CE2038", VA = "0x2CE2038")]
	private void SetHintTextTransform(float textHeight, float textWidth, Side anchorSide, TutorialUIType hintType)
	{
	}

	[Token(Token = "0x600DB3D")]
	[Address(RVA = "0x2CE17F4", Offset = "0x2CE17F4", VA = "0x2CE17F4")]
	private void BindCircleAndRectWithTrans(UIButton button, UIToggle bindToggleNotBtn, UIWidget sizeWidget)
	{
	}

	[Token(Token = "0x600DB3E")]
	[Address(RVA = "0x2CE308C", Offset = "0x2CE308C", VA = "0x2CE308C")]
	private void SetButtonClickEventDelegate(UIButton button, UIToggle bindToggleNotBtn)
	{
	}

	[Token(Token = "0x600DB3F")]
	[Address(RVA = "0x2CDFB30", Offset = "0x2CDFB30", VA = "0x2CDFB30")]
	private void RemoveButtonClickEventDelegate(UIButton bindBtn, UIToggle bindToggle)
	{
	}

	[Token(Token = "0x600DB40")]
	[Address(RVA = "0x2CE336C", Offset = "0x2CE336C", VA = "0x2CE336C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DB41")]
	[Address(RVA = "0x2CE3374", Offset = "0x2CE3374", VA = "0x2CE3374")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600DB42")]
	[Address(RVA = "0x2CE337C", Offset = "0x2CE337C", VA = "0x2CE337C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DB43")]
	[Address(RVA = "0x2CE3384", Offset = "0x2CE3384", VA = "0x2CE3384")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
