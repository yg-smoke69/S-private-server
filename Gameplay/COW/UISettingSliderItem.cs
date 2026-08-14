using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D3A")]
public class UISettingSliderItem : MonoBehaviour
{
	[Token(Token = "0x40114B1")]
	[FieldOffset(Offset = "0xC")]
	public UISlider SettingSlider;

	[Token(Token = "0x40114B2")]
	[FieldOffset(Offset = "0x10")]
	public UILabel SettingValue;

	[Token(Token = "0x40114B3")]
	[FieldOffset(Offset = "0x14")]
	public Action ImmediatelyApplyCallBack;

	[Token(Token = "0x40114B4")]
	[FieldOffset(Offset = "0x18")]
	public Func<float> GetSettingFunc;

	[Token(Token = "0x40114B5")]
	[FieldOffset(Offset = "0x1C")]
	public Action<float> SetSettingFunc;

	[Token(Token = "0x6012EC6")]
	[Address(RVA = "0x1A5EB14", Offset = "0x1A5EB14", VA = "0x1A5EB14")]
	public UISettingSliderItem()
	{
	}

	[Token(Token = "0x6012EC7")]
	[Address(RVA = "0x1A5EB1C", Offset = "0x1A5EB1C", VA = "0x1A5EB1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6012EC8")]
	[Address(RVA = "0x1A5EC84", Offset = "0x1A5EC84", VA = "0x1A5EC84")]
	private void OnSliderChange()
	{
	}

	[Token(Token = "0x6012EC9")]
	[Address(RVA = "0x1A5EE30", Offset = "0x1A5EE30", VA = "0x1A5EE30")]
	public void SetSliderValue(float v)
	{
	}
}
