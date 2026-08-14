using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023F3")]
public class UITutorialIndicatorController : UIBaseController
{
	[Token(Token = "0x400E01D")]
	[FieldOffset(Offset = "0x28")]
	private UITutorialIndicatorView m_View;

	[Token(Token = "0x400E01E")]
	[FieldOffset(Offset = "0x2C")]
	private UITutorialIndicatorCharacterController m_UICharacter;

	[Token(Token = "0x400E01F")]
	[FieldOffset(Offset = "0x30")]
	private UITutorialIndicatorHandController m_UIHand;

	[Token(Token = "0x400E020")]
	private const float TextIntervalWithCircle = 85f;

	[Token(Token = "0x400E021")]
	private const float TextIntervalWithCharacter = 50f;

	[Token(Token = "0x400E022")]
	private const int DefaultCircleWidth = 100;

	[Token(Token = "0x400E023")]
	private const int DefaultRectWidth = 300;

	[Token(Token = "0x400E024")]
	private const int DefaultRectHeight = 100;

	[Token(Token = "0x400E025")]
	private const int SafeAreaBorder = 40;

	[Token(Token = "0x400E026")]
	private const int OriginalDepth = 29;

	[Token(Token = "0x400E027")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, Quaternion> m_ArrowQuaternionDict;

	[Token(Token = "0x400E028")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, Vector2> m_ArrowAnchorPixelOffetDict;

	[Token(Token = "0x400E029")]
	[FieldOffset(Offset = "0x3C")]
	private TutorialSetting m_TutSetting;

	[Token(Token = "0x400E02A")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_ButtonTrans;

	[Token(Token = "0x400E02B")]
	[FieldOffset(Offset = "0x44")]
	private UIWidget m_BindWidget;

	[Token(Token = "0x400E02C")]
	[FieldOffset(Offset = "0x48")]
	private EventDelegate m_TmpClickEvent;

	[Token(Token = "0x400E02D")]
	[FieldOffset(Offset = "0x4C")]
	private float m_CachTextWidth;

	[Token(Token = "0x400E02E")]
	[FieldOffset(Offset = "0x50")]
	private AdjacentEdge m_CachAdjacentEdge;

	[Token(Token = "0x400E02F")]
	[FieldOffset(Offset = "0x54")]
	private TutorialUIType m_CachHintType;

	[Token(Token = "0x400E030")]
	[FieldOffset(Offset = "0x58")]
	private float m_CacheTopOffset;

	[Token(Token = "0x400E031")]
	[FieldOffset(Offset = "0x5C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400E032")]
	[FieldOffset(Offset = "0x60")]
	private readonly Vector3 HintWithCharacterHintPos;

	[Token(Token = "0x400E033")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_bIsForceComplete;

	[Token(Token = "0x400E034")]
	[FieldOffset(Offset = "0x70")]
	private UIButton m_ForceExecute;

	[Token(Token = "0x400E035")]
	[FieldOffset(Offset = "0x74")]
	private uint m_uMaskAllOverTimerActID;

	[Token(Token = "0x600CAD1")]
	[Address(RVA = "0x2B7762C", Offset = "0x2B7762C", VA = "0x2B7762C")]
	public UITutorialIndicatorController()
	{
	}

	[Token(Token = "0x600CAD2")]
	[Address(RVA = "0x2B77A3C", Offset = "0x2B77A3C", VA = "0x2B77A3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CAD3")]
	[Address(RVA = "0x2B77AE0", Offset = "0x2B77AE0", VA = "0x2B77AE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CAD4")]
	[Address(RVA = "0x2B77F80", Offset = "0x2B77F80", VA = "0x2B77F80")]
	private void OnClickMaskBtn()
	{
	}

	[Token(Token = "0x600CAD5")]
	[Address(RVA = "0x2B781BC", Offset = "0x2B781BC", VA = "0x2B781BC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CAD6")]
	[Address(RVA = "0x2B783C0", Offset = "0x2B783C0", VA = "0x2B783C0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600CAD7")]
	[Address(RVA = "0x2B78794", Offset = "0x2B78794", VA = "0x2B78794")]
	public void Reset()
	{
	}

	[Token(Token = "0x600CAD8")]
	[Address(RVA = "0x2B7842C", Offset = "0x2B7842C", VA = "0x2B7842C")]
	private void ResetChilds()
	{
	}

	[Token(Token = "0x600CAD9")]
	[Address(RVA = "0x2B78D54", Offset = "0x2B78D54", VA = "0x2B78D54")]
	public void ShowTutorialAtPosition(UIButton bindBtn, UIWidget bindWidget, TutorialSetting tutSetting)
	{
	}

	[Token(Token = "0x600CADA")]
	[Address(RVA = "0x2B78B44", Offset = "0x2B78B44", VA = "0x2B78B44")]
	private void SetDepth(bool abovePopup)
	{
	}

	[Token(Token = "0x600CADB")]
	[Address(RVA = "0x2B7B81C", Offset = "0x2B7B81C", VA = "0x2B7B81C")]
	private bool CheckHintCharacterNeedShow(TutorialUIType hintType)
	{
		return default(bool);
	}

	[Token(Token = "0x600CADC")]
	[Address(RVA = "0x2B7A0AC", Offset = "0x2B7A0AC", VA = "0x2B7A0AC")]
	private void SetHintCharacterActive(bool active)
	{
	}

	[Token(Token = "0x600CADD")]
	[Address(RVA = "0x2B7B91C", Offset = "0x2B7B91C", VA = "0x2B7B91C")]
	public void UpdatePosition(Transform showTrans, bool changed = true)
	{
	}

	[Token(Token = "0x600CADE")]
	[Address(RVA = "0x2B7BCAC", Offset = "0x2B7BCAC", VA = "0x2B7BCAC")]
	public void UpdateWholePosition(Transform showTrans)
	{
	}

	[Token(Token = "0x600CADF")]
	[Address(RVA = "0x2B7BFC0", Offset = "0x2B7BFC0", VA = "0x2B7BFC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600CAE0")]
	[Address(RVA = "0x2B7A2A8", Offset = "0x2B7A2A8", VA = "0x2B7A2A8")]
	private AdjacentEdge GetAdjacentEdge(Vector3 position)
	{
		return default(AdjacentEdge);
	}

	[Token(Token = "0x600CAE1")]
	[Address(RVA = "0x2B7A510", Offset = "0x2B7A510", VA = "0x2B7A510")]
	private void ArrowRotateAndSetPosForAdjacentEdge(AdjacentEdge adjacentEdge, GameObject arrowContainer)
	{
	}

	[Token(Token = "0x600CAE2")]
	[Address(RVA = "0x2B7AE94", Offset = "0x2B7AE94", VA = "0x2B7AE94")]
	private void SetHintTextTransform(float textWidth, AdjacentEdge adjacentEdge, TutorialUIType hintType, float topOffset)
	{
	}

	[Token(Token = "0x600CAE3")]
	[Address(RVA = "0x2B7C53C", Offset = "0x2B7C53C", VA = "0x2B7C53C")]
	private void AdjustPosInSafeArea(float leftDelta, float rightDelta, float topDelta, float bottomDelta)
	{
	}

	[Token(Token = "0x600CAE4")]
	[Address(RVA = "0x2B7A750", Offset = "0x2B7A750", VA = "0x2B7A750")]
	private void BindCircleAndRectWithTrans(UIButton button, UIWidget sizeWidget)
	{
	}

	[Token(Token = "0x600CAE5")]
	[Address(RVA = "0x2B7C94C", Offset = "0x2B7C94C", VA = "0x2B7C94C")]
	private void SetButtonClickEventDelegate(UIButton button)
	{
	}

	[Token(Token = "0x600CAE6")]
	[Address(RVA = "0x2B788B0", Offset = "0x2B788B0", VA = "0x2B788B0")]
	private void RemoveButtonClickEventDelegate(Transform buttonTransform)
	{
	}

	[Token(Token = "0x600CAE7")]
	[Address(RVA = "0x2B7CB98", Offset = "0x2B7CB98", VA = "0x2B7CB98")]
	private void FinishCurrentTutoOnClick()
	{
	}

	[Token(Token = "0x600CAE8")]
	[Address(RVA = "0x2B7CCCC", Offset = "0x2B7CCCC", VA = "0x2B7CCCC")]
	private void LogStopByClick()
	{
	}

	[Token(Token = "0x600CAE9")]
	[Address(RVA = "0x2B7C1AC", Offset = "0x2B7C1AC", VA = "0x2B7C1AC")]
	private bool CheckTargetInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600CAEA")]
	[Address(RVA = "0x2B7CECC", Offset = "0x2B7CECC", VA = "0x2B7CECC")]
	public void FinishCurrentTutorial(object[] param)
	{
	}

	[Token(Token = "0x600CAEB")]
	[Address(RVA = "0x2B7D008", Offset = "0x2B7D008", VA = "0x2B7D008")]
	public bool IsForceComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x600CAEC")]
	[Address(RVA = "0x2B7D060", Offset = "0x2B7D060", VA = "0x2B7D060")]
	public void SetForceComplete()
	{
	}

	[Token(Token = "0x600CAED")]
	[Address(RVA = "0x2B7D0BC", Offset = "0x2B7D0BC", VA = "0x2B7D0BC")]
	public void ForceComplete()
	{
	}

	[Token(Token = "0x600CAEE")]
	[Address(RVA = "0x2B7D200", Offset = "0x2B7D200", VA = "0x2B7D200")]
	public void OpenMaskAll()
	{
	}

	[Token(Token = "0x600CAEF")]
	[Address(RVA = "0x2B77E18", Offset = "0x2B77E18", VA = "0x2B77E18")]
	public void CloseMaskAll()
	{
	}

	[Token(Token = "0x600CAF0")]
	[Address(RVA = "0x2B7D424", Offset = "0x2B7D424", VA = "0x2B7D424")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CAF1")]
	[Address(RVA = "0x2B7D42C", Offset = "0x2B7D42C", VA = "0x2B7D42C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600CAF2")]
	[Address(RVA = "0x2B7D434", Offset = "0x2B7D434", VA = "0x2B7D434")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
