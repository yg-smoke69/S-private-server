using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020D7")]
public class UIEPTaskEntryController : UIBaseController
{
	[Token(Token = "0x400CD89")]
	[FieldOffset(Offset = "0x28")]
	private UIEPTaskEntryView m_View;

	[Token(Token = "0x400CD8A")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400CD8B")]
	private const string KEY_NEW_TAG = "EPTaskEntry_NewTag_";

	[Token(Token = "0x600A9FD")]
	[Address(RVA = "0x2BAF014", Offset = "0x2BAF014", VA = "0x2BAF014")]
	public UIEPTaskEntryController()
	{
	}

	[Token(Token = "0x600A9FE")]
	[Address(RVA = "0x2BAF098", Offset = "0x2BAF098", VA = "0x2BAF098", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9FF")]
	[Address(RVA = "0x2BAF6B4", Offset = "0x2BAF6B4", VA = "0x2BAF6B4")]
	public GameObject GetIconObj()
	{
		return null;
	}

	[Token(Token = "0x600AA00")]
	[Address(RVA = "0x2BAF740", Offset = "0x2BAF740", VA = "0x2BAF740")]
	public GameObject GetProgressObj()
	{
		return null;
	}

	[Token(Token = "0x600AA01")]
	[Address(RVA = "0x2BAF804", Offset = "0x2BAF804", VA = "0x2BAF804", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AA02")]
	[Address(RVA = "0x2BAF9A0", Offset = "0x2BAF9A0", VA = "0x2BAF9A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA03")]
	[Address(RVA = "0x2BAFA44", Offset = "0x2BAFA44", VA = "0x2BAFA44")]
	private void OnEntryClick()
	{
	}

	[Token(Token = "0x600AA04")]
	[Address(RVA = "0x2BAF3D8", Offset = "0x2BAF3D8", VA = "0x2BAF3D8")]
	private void SetEpEntranceTips()
	{
	}

	[Token(Token = "0x600AA05")]
	[Address(RVA = "0x2BAFE34", Offset = "0x2BAFE34", VA = "0x2BAFE34")]
	private void RefreshProcessBar()
	{
	}

	[Token(Token = "0x600AA06")]
	[Address(RVA = "0x2BAFF00", Offset = "0x2BAFF00", VA = "0x2BAFF00")]
	private void SetRedPointState(object[] data)
	{
	}

	[Token(Token = "0x600AA07")]
	[Address(RVA = "0x2BB0044", Offset = "0x2BB0044", VA = "0x2BB0044")]
	private void OnEPProcessUpdate(object[] data)
	{
	}

	[Token(Token = "0x600AA08")]
	[Address(RVA = "0x2BB00AC", Offset = "0x2BB00AC", VA = "0x2BB00AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA09")]
	[Address(RVA = "0x2BB00B4", Offset = "0x2BB00B4", VA = "0x2BB00B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
