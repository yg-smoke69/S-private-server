using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D24")]
public class BountyScannerMapObject
{
	[Token(Token = "0x40113A9")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_MarkContainer;

	[Token(Token = "0x40113AA")]
	[FieldOffset(Offset = "0xC")]
	private UISprite m_MarkSprite;

	[Token(Token = "0x40113AB")]
	[FieldOffset(Offset = "0x10")]
	private UISprite m_DirectionSprite;

	[Token(Token = "0x40113AC")]
	[FieldOffset(Offset = "0x14")]
	private TweenAlpha m_MarkerTween;

	[Token(Token = "0x40113AD")]
	[FieldOffset(Offset = "0x18")]
	private TweenAlpha m_DirectionTween;

	[Token(Token = "0x40113AE")]
	[FieldOffset(Offset = "0x1C")]
	private UIMapUtil.EMapType m_MapType;

	[Token(Token = "0x40113AF")]
	[FieldOffset(Offset = "0x20")]
	private float m_Scale;

	[Token(Token = "0x40113B0")]
	[FieldOffset(Offset = "0x24")]
	private HNLLDHPPEKL m_BountyManager;

	[Token(Token = "0x40113B1")]
	[FieldOffset(Offset = "0x28")]
	private UIPanel m_MinimapPanel;

	[Token(Token = "0x40113B2")]
	private const float MINIMAP_DIECTION_RANGE = 90f;

	[Token(Token = "0x6012DF7")]
	[Address(RVA = "0x180FD98", Offset = "0x180FD98", VA = "0x180FD98")]
	public BountyScannerMapObject()
	{
	}

	[Token(Token = "0x6012DF8")]
	[Address(RVA = "0x180FDB0", Offset = "0x180FDB0", VA = "0x180FDB0")]
	public void OnUIInit(Transform container, UISprite markSprite, TweenAlpha markTween, float scale, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Bigmap, [Optional] UISprite directionSprite, [Optional] TweenAlpha directionTween)
	{
	}

	[Token(Token = "0x6012DF9")]
	[Address(RVA = "0x181022C", Offset = "0x181022C", VA = "0x181022C")]
	public void SetMinimap(UIPanel panel)
	{
	}

	[Token(Token = "0x6012DFA")]
	[Address(RVA = "0x1810298", Offset = "0x1810298", VA = "0x1810298")]
	public void OnUIDestory()
	{
	}

	[Token(Token = "0x6012DFB")]
	[Address(RVA = "0x1810428", Offset = "0x1810428", VA = "0x1810428")]
	private void RefreshUIView(object[] data)
	{
	}

	[Token(Token = "0x6012DFC")]
	[Address(RVA = "0x1810858", Offset = "0x1810858", VA = "0x1810858")]
	private void HideBountyView(object[] data)
	{
	}

	[Token(Token = "0x6012DFD")]
	[Address(RVA = "0x1810520", Offset = "0x1810520", VA = "0x1810520")]
	private void ShowMark()
	{
	}

	[Token(Token = "0x6012DFE")]
	[Address(RVA = "0x181097C", Offset = "0x181097C", VA = "0x181097C")]
	public void ShowMarkDirection()
	{
	}

	[Token(Token = "0x6012DFF")]
	[Address(RVA = "0x1811080", Offset = "0x1811080", VA = "0x1811080")]
	public bool IsMarkDirectionActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6012E00")]
	[Address(RVA = "0x18106EC", Offset = "0x18106EC", VA = "0x18106EC")]
	private void ShowPlayerTween()
	{
	}

	[Token(Token = "0x6012E01")]
	[Address(RVA = "0x18100E8", Offset = "0x18100E8", VA = "0x18100E8")]
	private void HideMarkerTween()
	{
	}
}
