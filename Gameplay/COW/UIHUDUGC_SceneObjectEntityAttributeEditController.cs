using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002474")]
public class UIHUDUGC_SceneObjectEntityAttributeEditController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E237")]
	[FieldOffset(Offset = "0x48")]
	private UIHUDUGC_SceneObjectEntityAttributeEditView m_View;

	[Token(Token = "0x400E238")]
	[FieldOffset(Offset = "0x4C")]
	private List<GALLODIEHAA> m_EntityAttributeData;

	[Token(Token = "0x400E239")]
	[FieldOffset(Offset = "0x50")]
	private FONLAPPBCOO m_Type;

	[Token(Token = "0x600CFB1")]
	[Address(RVA = "0x291BDD8", Offset = "0x291BDD8", VA = "0x291BDD8")]
	public UIHUDUGC_SceneObjectEntityAttributeEditController()
	{
	}

	[Token(Token = "0x600CFB2")]
	[Address(RVA = "0x291BDE0", Offset = "0x291BDE0", VA = "0x291BDE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CFB3")]
	[Address(RVA = "0x291BE84", Offset = "0x291BE84", VA = "0x291BE84", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CFB4")]
	[Address(RVA = "0x291BF00", Offset = "0x291BF00", VA = "0x291BF00", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CFB5")]
	[Address(RVA = "0x291C118", Offset = "0x291C118", VA = "0x291C118", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CFB6")]
	[Address(RVA = "0x291C604", Offset = "0x291C604", VA = "0x291C604")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x600CFB7")]
	[Address(RVA = "0x291C81C", Offset = "0x291C81C", VA = "0x291C81C")]
	private void RefreshListView()
	{
	}

	[Token(Token = "0x600CFB8")]
	[Address(RVA = "0x291C3D0", Offset = "0x291C3D0", VA = "0x291C3D0")]
	private string GetCoordinateString(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600CFB9")]
	[Address(RVA = "0x291C930", Offset = "0x291C930", VA = "0x291C930")]
	public void SetData(string entityId, FONLAPPBCOO type)
	{
	}

	[Token(Token = "0x600CFBA")]
	[Address(RVA = "0x291CA58", Offset = "0x291CA58", VA = "0x291CA58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
