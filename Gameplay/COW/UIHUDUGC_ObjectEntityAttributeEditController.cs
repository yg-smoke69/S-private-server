using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200245D")]
public class UIHUDUGC_ObjectEntityAttributeEditController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x200245E")]
	private enum Tab
	{
		[Token(Token = "0x400E1EE")]
		Attribute,
		[Token(Token = "0x400E1EF")]
		Info,
		[Token(Token = "0x400E1F0")]
		Count
	}

	[Token(Token = "0x200245F")]
	private sealed class _003CCheckVaild_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E1F1")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400E1F2")]
		[FieldOffset(Offset = "0xC")]
		internal UIHUDUGC_ObjectEntityAttributeEditController _0024this;

		[Token(Token = "0x600CEF4")]
		[Address(RVA = "0x2E1D0E0", Offset = "0x2E1D0E0", VA = "0x2E1D0E0")]
		public _003CCheckVaild_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2002460")]
	private sealed class _003CCheckVaild_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E1F3")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400E1F4")]
		[FieldOffset(Offset = "0xC")]
		internal _003CCheckVaild_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600CEF5")]
		[Address(RVA = "0x2E1D0E8", Offset = "0x2E1D0E8", VA = "0x2E1D0E8")]
		public _003CCheckVaild_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CEF6")]
		[Address(RVA = "0x2E1DBE8", Offset = "0x2E1DBE8", VA = "0x2E1DBE8")]
		internal bool _003C_003Em__0(DJMFJEMEKHM data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E1E5")]
	[FieldOffset(Offset = "0x48")]
	private string m_Id;

	[Token(Token = "0x400E1E6")]
	[FieldOffset(Offset = "0x4C")]
	private UIHUDUGC_ObjectEntityAttributeEditView m_View;

	[Token(Token = "0x400E1E7")]
	[FieldOffset(Offset = "0x50")]
	private CEIJKFCIALJ m_Data;

	[Token(Token = "0x400E1E8")]
	[FieldOffset(Offset = "0x54")]
	private Tab m_CurrentTab;

	[Token(Token = "0x400E1E9")]
	[FieldOffset(Offset = "0x58")]
	private GameObject[] m_TabGameObjects;

	[Token(Token = "0x400E1EA")]
	[FieldOffset(Offset = "0x5C")]
	private SceneEditPrefabConfigData m_ConfigData;

	[Token(Token = "0x400E1EB")]
	[FieldOffset(Offset = "0x60")]
	private HashSet<int> m_RedefineList;

	[Token(Token = "0x400E1EC")]
	[FieldOffset(Offset = "0x64")]
	private bool m_Redefined;

	[Token(Token = "0x600CEE0")]
	[Address(RVA = "0x2E1B930", Offset = "0x2E1B930", VA = "0x2E1B930")]
	public UIHUDUGC_ObjectEntityAttributeEditController()
	{
	}

	[Token(Token = "0x600CEE1")]
	[Address(RVA = "0x2E1B938", Offset = "0x2E1B938", VA = "0x2E1B938")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CEE2")]
	[Address(RVA = "0x2E1B9DC", Offset = "0x2E1B9DC", VA = "0x2E1B9DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CEE3")]
	[Address(RVA = "0x2E1BEB4", Offset = "0x2E1BEB4", VA = "0x2E1BEB4")]
	private void DeleteAttribute(object[] param)
	{
	}

	[Token(Token = "0x600CEE4")]
	[Address(RVA = "0x2E1C434", Offset = "0x2E1C434", VA = "0x2E1C434")]
	private void OnClickAttributeTab()
	{
	}

	[Token(Token = "0x600CEE5")]
	[Address(RVA = "0x2E1C870", Offset = "0x2E1C870", VA = "0x2E1C870")]
	private void OnClickInfoTab()
	{
	}

	[Token(Token = "0x600CEE6")]
	[Address(RVA = "0x2E1C498", Offset = "0x2E1C498", VA = "0x2E1C498")]
	private void SwitchTab(Tab tab)
	{
	}

	[Token(Token = "0x600CEE7")]
	[Address(RVA = "0x2E1C8D4", Offset = "0x2E1C8D4", VA = "0x2E1C8D4")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x600CEE8")]
	[Address(RVA = "0x2E1CD8C", Offset = "0x2E1CD8C", VA = "0x2E1CD8C")]
	private bool CheckVaild(out string reason)
	{
		return default(bool);
	}

	[Token(Token = "0x600CEE9")]
	[Address(RVA = "0x2E1D0F0", Offset = "0x2E1D0F0", VA = "0x2E1D0F0")]
	private void OnClickAddBtn()
	{
	}

	[Token(Token = "0x600CEEA")]
	[Address(RVA = "0x2E1C15C", Offset = "0x2E1C15C", VA = "0x2E1C15C")]
	private void RefreshItems()
	{
	}

	[Token(Token = "0x600CEEB")]
	[Address(RVA = "0x2E1D150", Offset = "0x2E1D150", VA = "0x2E1D150")]
	private void AddAttributeView()
	{
	}

	[Token(Token = "0x600CEEC")]
	[Address(RVA = "0x2E1D4FC", Offset = "0x2E1D4FC", VA = "0x2E1D4FC")]
	public void SetViewData(SceneEditPrefabConfigData prefabConfig, FONLAPPBCOO type)
	{
	}

	[Token(Token = "0x600CEED")]
	[Address(RVA = "0x2E1D64C", Offset = "0x2E1D64C", VA = "0x2E1D64C")]
	private void RefreshInfoView()
	{
	}

	[Token(Token = "0x600CEEE")]
	[Address(RVA = "0x2E1D7B8", Offset = "0x2E1D7B8", VA = "0x2E1D7B8", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CEEF")]
	[Address(RVA = "0x2E1DA2C", Offset = "0x2E1DA2C", VA = "0x2E1DA2C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CEF0")]
	[Address(RVA = "0x2E1DAA8", Offset = "0x2E1DAA8", VA = "0x2E1DAA8")]
	private void OnRedefineItem(int index)
	{
	}

	[Token(Token = "0x600CEF1")]
	[Address(RVA = "0x2E1DB74", Offset = "0x2E1DB74", VA = "0x2E1DB74", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CEF2")]
	[Address(RVA = "0x2E1DBD8", Offset = "0x2E1DBD8", VA = "0x2E1DBD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CEF3")]
	[Address(RVA = "0x2E1DBE0", Offset = "0x2E1DBE0", VA = "0x2E1DBE0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
