using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022F2")]
public class UISceneEditItemAttributeHorizonalSelet : UIBaseController
{
	[Token(Token = "0x400DA20")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditItemAttributeHorizontalSelectView m_View;

	[Token(Token = "0x400DA21")]
	[FieldOffset(Offset = "0x2C")]
	private List<string> m_OptionTxtKey;

	[Token(Token = "0x400DA22")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_OptionValues;

	[Token(Token = "0x400DA23")]
	[FieldOffset(Offset = "0x34")]
	private Action<object, int> m_ValueChangeCallbackTypeOne;

	[Token(Token = "0x400DA24")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurOptionIndex;

	[Token(Token = "0x170010A6")]
	private int CurOptionIndex
	{
		[Token(Token = "0x600C0C1")]
		[Address(RVA = "0x2D9DE60", Offset = "0x2D9DE60", VA = "0x2D9DE60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600C0C0")]
		[Address(RVA = "0x2D9D94C", Offset = "0x2D9D94C", VA = "0x2D9D94C")]
		set
		{
		}
	}

	[Token(Token = "0x600C0BE")]
	[Address(RVA = "0x2D9D824", Offset = "0x2D9D824", VA = "0x2D9D824")]
	public UISceneEditItemAttributeHorizonalSelet()
	{
	}

	[Token(Token = "0x600C0BF")]
	[Address(RVA = "0x2D9D8A8", Offset = "0x2D9D8A8", VA = "0x2D9D8A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C0C2")]
	[Address(RVA = "0x2D9DEB8", Offset = "0x2D9DEB8", VA = "0x2D9DEB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C0C3")]
	[Address(RVA = "0x2D9E088", Offset = "0x2D9E088", VA = "0x2D9E088")]
	public void InitShowData(string titleName, List<string> optionTxtKey, List<int> optionValues, int curValue)
	{
	}

	[Token(Token = "0x600C0C4")]
	[Address(RVA = "0x2D9E2A0", Offset = "0x2D9E2A0", VA = "0x2D9E2A0")]
	public void RegisetrValueChangeCallback(Action<object, int> callBack)
	{
	}

	[Token(Token = "0x600C0C5")]
	[Address(RVA = "0x2D9E300", Offset = "0x2D9E300", VA = "0x2D9E300")]
	private void OnLeftClick()
	{
	}

	[Token(Token = "0x600C0C6")]
	[Address(RVA = "0x2D9E36C", Offset = "0x2D9E36C", VA = "0x2D9E36C")]
	private void OnRightClick()
	{
	}

	[Token(Token = "0x600C0C7")]
	[Address(RVA = "0x2D9DC20", Offset = "0x2D9DC20", VA = "0x2D9DC20")]
	private void EnableLeft(bool isEnable)
	{
	}

	[Token(Token = "0x600C0C8")]
	[Address(RVA = "0x2D9DD40", Offset = "0x2D9DD40", VA = "0x2D9DD40")]
	private void EnabelRight(bool isEnable)
	{
	}

	[Token(Token = "0x600C0C9")]
	[Address(RVA = "0x2D9E3D8", Offset = "0x2D9E3D8", VA = "0x2D9E3D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
