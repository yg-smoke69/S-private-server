using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025AB")]
public class UICountDownController : UIBaseController
{
	[Token(Token = "0x20025AC")]
	public enum AlignmentType
	{
		[Token(Token = "0x400E8F2")]
		LEFT,
		[Token(Token = "0x400E8F3")]
		CENTER,
		[Token(Token = "0x400E8F4")]
		RIGHT
	}

	[Token(Token = "0x20025AD")]
	public enum EIconType
	{
		[Token(Token = "0x400E8F6")]
		TIME1,
		[Token(Token = "0x400E8F7")]
		TIME2,
		[Token(Token = "0x400E8F8")]
		Lock
	}

	[Token(Token = "0x400E8ED")]
	[FieldOffset(Offset = "0x28")]
	private List<string> m_IconList;

	[Token(Token = "0x400E8EE")]
	[FieldOffset(Offset = "0x2C")]
	private UICountDownView m_View;

	[Token(Token = "0x400E8EF")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_UILabel;

	[Token(Token = "0x400E8F0")]
	[FieldOffset(Offset = "0x34")]
	private Action m_CountDownIconClickHandler;

	[Token(Token = "0x600DC72")]
	[Address(RVA = "0x1EBFF4C", Offset = "0x1EBFF4C", VA = "0x1EBFF4C")]
	public UICountDownController()
	{
	}

	[Token(Token = "0x600DC73")]
	[Address(RVA = "0x1EC00D0", Offset = "0x1EC00D0", VA = "0x1EC00D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC74")]
	[Address(RVA = "0x1EC0174", Offset = "0x1EC0174", VA = "0x1EC0174", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC75")]
	[Address(RVA = "0x1EC037C", Offset = "0x1EC037C", VA = "0x1EC037C")]
	public void SetIconShow(bool show)
	{
	}

	[Token(Token = "0x600DC76")]
	[Address(RVA = "0x1EC0434", Offset = "0x1EC0434", VA = "0x1EC0434")]
	public void Rotate(float degree)
	{
	}

	[Token(Token = "0x600DC77")]
	[Address(RVA = "0x1EC0560", Offset = "0x1EC0560", VA = "0x1EC0560")]
	public void RefreshCountDown(ulong end, string prefix = "", string suffix = "", bool formated = true, [Optional] OnStarted onStarted, [Optional] OnFinished onFinished, bool isStarted = true)
	{
	}

	[Token(Token = "0x600DC78")]
	[Address(RVA = "0x1EC09F4", Offset = "0x1EC09F4", VA = "0x1EC09F4")]
	public void SetIconStyle(EIconType iconType)
	{
	}

	[Token(Token = "0x600DC79")]
	[Address(RVA = "0x1EC0B68", Offset = "0x1EC0B68", VA = "0x1EC0B68")]
	public void SetStyle(AlignmentType alignmentType = AlignmentType.LEFT, EIconType iconType = EIconType.TIME1, Effect labelStyle = 1, bool applyGradient = false, uint gradientTop = 16777215u, uint gradientBottom = 0u)
	{
	}

	[Token(Token = "0x600DC7A")]
	[Address(RVA = "0x1EC1338", Offset = "0x1EC1338", VA = "0x1EC1338")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600DC7B")]
	[Address(RVA = "0x1EC145C", Offset = "0x1EC145C", VA = "0x1EC145C")]
	public void SetFontSize(int size)
	{
	}

	[Token(Token = "0x600DC7C")]
	[Address(RVA = "0x1EC14E0", Offset = "0x1EC14E0", VA = "0x1EC14E0")]
	public void SetFontStyle(FontStyle style)
	{
	}

	[Token(Token = "0x600DC7D")]
	[Address(RVA = "0x1EC1564", Offset = "0x1EC1564", VA = "0x1EC1564")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600DC7E")]
	[Address(RVA = "0x1EC1660", Offset = "0x1EC1660", VA = "0x1EC1660")]
	public void SetColor(uint color)
	{
	}

	[Token(Token = "0x600DC7F")]
	[Address(RVA = "0x1EC12B4", Offset = "0x1EC12B4", VA = "0x1EC12B4")]
	public void SetLabelEffect(Effect effectStyle)
	{
	}

	[Token(Token = "0x600DC80")]
	[Address(RVA = "0x1EC1760", Offset = "0x1EC1760", VA = "0x1EC1760")]
	public void SetLabelEffect2(Effect effectStyle)
	{
	}

	[Token(Token = "0x600DC81")]
	[Address(RVA = "0x1EC17E4", Offset = "0x1EC17E4", VA = "0x1EC17E4")]
	public void SetLabelEffectColor(uint color, Vector2 effectSize)
	{
	}

	[Token(Token = "0x600DC82")]
	[Address(RVA = "0x1EC18C8", Offset = "0x1EC18C8", VA = "0x1EC18C8")]
	public void SetLabelEffect2Color(uint color, Vector2 effectSize)
	{
	}

	[Token(Token = "0x600DC83")]
	[Address(RVA = "0x1EC19AC", Offset = "0x1EC19AC", VA = "0x1EC19AC")]
	public void ShowCountDownBg(bool value)
	{
	}

	[Token(Token = "0x600DC84")]
	[Address(RVA = "0x1EC1AC0", Offset = "0x1EC1AC0", VA = "0x1EC1AC0")]
	public void ShowCountDownBar(bool value)
	{
	}

	[Token(Token = "0x600DC85")]
	[Address(RVA = "0x1EC1BB4", Offset = "0x1EC1BB4", VA = "0x1EC1BB4")]
	public void SetLabelText(string text)
	{
	}

	[Token(Token = "0x600DC86")]
	[Address(RVA = "0x1EC1C4C", Offset = "0x1EC1C4C", VA = "0x1EC1C4C")]
	public void SetLabel(string value)
	{
	}

	[Token(Token = "0x600DC87")]
	[Address(RVA = "0x1EC1CD0", Offset = "0x1EC1CD0", VA = "0x1EC1CD0")]
	public UILabel GetLabel()
	{
		return null;
	}

	[Token(Token = "0x600DC88")]
	[Address(RVA = "0x1EC1D28", Offset = "0x1EC1D28", VA = "0x1EC1D28")]
	public void Cancel()
	{
	}

	[Token(Token = "0x600DC89")]
	[Address(RVA = "0x1EC1E98", Offset = "0x1EC1E98", VA = "0x1EC1E98")]
	public void SetCountDownIconClickCallback(Action callback)
	{
	}

	[Token(Token = "0x600DC8A")]
	[Address(RVA = "0x1EC200C", Offset = "0x1EC200C", VA = "0x1EC200C")]
	private void OnCountDownIconClick()
	{
	}

	[Token(Token = "0x600DC8B")]
	[Address(RVA = "0x1EC2078", Offset = "0x1EC2078", VA = "0x1EC2078")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600DC8C")]
	[Address(RVA = "0x1EC2148", Offset = "0x1EC2148", VA = "0x1EC2148")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
