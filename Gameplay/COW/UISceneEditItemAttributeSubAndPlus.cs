using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022F5")]
public class UISceneEditItemAttributeSubAndPlus : UIBaseController
{
	[Token(Token = "0x400DA3A")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditItemAttributeSubAndPlusView m_View;

	[Token(Token = "0x400DA3B")]
	[FieldOffset(Offset = "0x2C")]
	private Action<object, int> m_ValueChangeCallbackTypeOne;

	[Token(Token = "0x400DA3C")]
	[FieldOffset(Offset = "0x30")]
	private float m_CurValue;

	[Token(Token = "0x400DA3D")]
	[FieldOffset(Offset = "0x34")]
	private float m_MinValue;

	[Token(Token = "0x400DA3E")]
	[FieldOffset(Offset = "0x38")]
	private float m_MaxValue;

	[Token(Token = "0x400DA3F")]
	[FieldOffset(Offset = "0x3C")]
	private float m_StepValue;

	[Token(Token = "0x170010A8")]
	private float CurValue
	{
		[Token(Token = "0x600C0EA")]
		[Address(RVA = "0x2DA3494", Offset = "0x2DA3494", VA = "0x2DA3494")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C0E9")]
		[Address(RVA = "0x2DA3020", Offset = "0x2DA3020", VA = "0x2DA3020")]
		set
		{
		}
	}

	[Token(Token = "0x600C0E7")]
	[Address(RVA = "0x2DA2EF8", Offset = "0x2DA2EF8", VA = "0x2DA2EF8")]
	public UISceneEditItemAttributeSubAndPlus()
	{
	}

	[Token(Token = "0x600C0E8")]
	[Address(RVA = "0x2DA2F7C", Offset = "0x2DA2F7C", VA = "0x2DA2F7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C0EB")]
	[Address(RVA = "0x2DA34EC", Offset = "0x2DA34EC", VA = "0x2DA34EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C0EC")]
	[Address(RVA = "0x2DA3794", Offset = "0x2DA3794", VA = "0x2DA3794")]
	public void InitShowData(string titleName, float minValue, float maxValue, float stepValue, float curValue)
	{
	}

	[Token(Token = "0x600C0ED")]
	[Address(RVA = "0x2DA3994", Offset = "0x2DA3994", VA = "0x2DA3994")]
	public void RegisetrValueChangeCallback(Action<object, int> callBack)
	{
	}

	[Token(Token = "0x600C0EE")]
	[Address(RVA = "0x2DA39F4", Offset = "0x2DA39F4", VA = "0x2DA39F4")]
	private void OnSubClick()
	{
	}

	[Token(Token = "0x600C0EF")]
	[Address(RVA = "0x2DA3A6C", Offset = "0x2DA3A6C", VA = "0x2DA3A6C")]
	private void OnPlusClick()
	{
	}

	[Token(Token = "0x600C0F0")]
	[Address(RVA = "0x2DA3AE4", Offset = "0x2DA3AE4", VA = "0x2DA3AE4")]
	private void OnResetInput()
	{
	}

	[Token(Token = "0x600C0F1")]
	[Address(RVA = "0x2DA3B50", Offset = "0x2DA3B50", VA = "0x2DA3B50")]
	private void OnInputSubmit()
	{
	}

	[Token(Token = "0x600C0F2")]
	[Address(RVA = "0x2DA332C", Offset = "0x2DA332C", VA = "0x2DA332C")]
	private void EnabelPlus(bool isEnabel)
	{
	}

	[Token(Token = "0x600C0F3")]
	[Address(RVA = "0x2DA320C", Offset = "0x2DA320C", VA = "0x2DA320C")]
	private void EnabelSub(bool isEnabel)
	{
	}

	[Token(Token = "0x600C0F4")]
	[Address(RVA = "0x2DA3D18", Offset = "0x2DA3D18", VA = "0x2DA3D18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
