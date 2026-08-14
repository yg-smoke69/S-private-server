using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004173")]
public class UIToggleSlideButtonGroup : MonoBehaviour
{
	[Token(Token = "0x2004174")]
	public delegate void OnItemSelect(UIToggleButton selectButton);

	[Token(Token = "0x2004175")]
	public delegate void OnItemUnSelect(UIToggleButton selectButton);

	[Token(Token = "0x401B736")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton FirstButton;

	[Token(Token = "0x401B737")]
	[FieldOffset(Offset = "0x10")]
	public UIToggleButton SecondButton;

	[Token(Token = "0x401B738")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton DefaultClickBtn;

	[Token(Token = "0x401B739")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition Slider;

	[Token(Token = "0x401B73A")]
	[FieldOffset(Offset = "0x1C")]
	public OnItemSelect OnItemSelectCallback;

	[Token(Token = "0x401B73B")]
	[FieldOffset(Offset = "0x20")]
	public OnItemSelect OnItemUnSelectCallback;

	[Token(Token = "0x401B73C")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_FirstPos;

	[Token(Token = "0x401B73D")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_SecondPos;

	[Token(Token = "0x401B73E")]
	[FieldOffset(Offset = "0x3C")]
	private TweenColor m_TweenColorFirstLabel;

	[Token(Token = "0x401B73F")]
	[FieldOffset(Offset = "0x40")]
	private TweenColor m_TweenColorSecondLabel;

	[Token(Token = "0x401B740")]
	[FieldOffset(Offset = "0x0")]
	private static Color LabelEnable;

	[Token(Token = "0x401B741")]
	[FieldOffset(Offset = "0x10")]
	private static Color LabelDisable;

	[Token(Token = "0x601ABE6")]
	[Address(RVA = "0x2BC05B8", Offset = "0x2BC05B8", VA = "0x2BC05B8")]
	public UIToggleSlideButtonGroup()
	{
	}

	[Token(Token = "0x601ABE7")]
	[Address(RVA = "0x2BC05C0", Offset = "0x2BC05C0", VA = "0x2BC05C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x601ABE8")]
	[Address(RVA = "0x2BC0984", Offset = "0x2BC0984", VA = "0x2BC0984")]
	public void SetDefaultBtn(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x601ABE9")]
	[Address(RVA = "0x2BC0E00", Offset = "0x2BC0E00", VA = "0x2BC0E00")]
	public void PlayTween(bool forward)
	{
	}

	[Token(Token = "0x601ABEA")]
	[Address(RVA = "0x2BC081C", Offset = "0x2BC081C", VA = "0x2BC081C")]
	public void OnSelectButton(UIToggleButton selectedButton)
	{
	}

	[Token(Token = "0x601ABEB")]
	[Address(RVA = "0x2BC1728", Offset = "0x2BC1728", VA = "0x2BC1728")]
	public void RefreshButtonStates()
	{
	}
}
