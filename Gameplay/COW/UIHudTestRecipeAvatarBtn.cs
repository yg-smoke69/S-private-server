using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002871")]
public class UIHudTestRecipeAvatarBtn : MonoBehaviour
{
	[Token(Token = "0x400F950")]
	[FieldOffset(Offset = "0xC")]
	public CSSharedAvatarData AData;

	[Token(Token = "0x400F951")]
	[FieldOffset(Offset = "0x10")]
	public Action<CSSharedAvatarData> m_ClickCB;

	[Token(Token = "0x600FD99")]
	[Address(RVA = "0x17B119C", Offset = "0x17B119C", VA = "0x17B119C")]
	public UIHudTestRecipeAvatarBtn()
	{
	}

	[Token(Token = "0x600FD9A")]
	[Address(RVA = "0x17B11A4", Offset = "0x17B11A4", VA = "0x17B11A4")]
	public void SetAvatarData(CSSharedAvatarData data, Action<CSSharedAvatarData> cb)
	{
	}

	[Token(Token = "0x600FD9B")]
	[Address(RVA = "0x17B1444", Offset = "0x17B1444", VA = "0x17B1444")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FD9C")]
	[Address(RVA = "0x17B14FC", Offset = "0x17B14FC", VA = "0x17B14FC")]
	private void Destroy()
	{
	}
}
