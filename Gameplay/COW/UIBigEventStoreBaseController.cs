using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F91")]
internal class UIBigEventStoreBaseController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x400C619")]
	[FieldOffset(Offset = "0x70")]
	private UIEasyList m_EasyList;

	[Token(Token = "0x400C61A")]
	[FieldOffset(Offset = "0x74")]
	private bool m_IsInit;

	[Token(Token = "0x400C61B")]
	[FieldOffset(Offset = "0x78")]
	private LimitedEventStore m_StoreData;

	[Token(Token = "0x17000F9B")]
	public UIEasyList StoreEasyList
	{
		[Token(Token = "0x6009D1A")]
		[Address(RVA = "0x3017208", Offset = "0x3017208", VA = "0x3017208")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009D1B")]
		[Address(RVA = "0x3017304", Offset = "0x3017304", VA = "0x3017304")]
		set
		{
		}
	}

	[Token(Token = "0x6009D19")]
	[Address(RVA = "0x3017200", Offset = "0x3017200", VA = "0x3017200")]
	public UIBigEventStoreBaseController()
	{
	}

	[Token(Token = "0x6009D1C")]
	[Address(RVA = "0x3017364", Offset = "0x3017364", VA = "0x3017364")]
	public void SetViewData(LimitedEventStore storeData)
	{
	}

	[Token(Token = "0x6009D1D")]
	[Address(RVA = "0x30174BC", Offset = "0x30174BC", VA = "0x30174BC", Slot = "48")]
	public virtual UIBigEventStoreItemBaseController GetStoreItemController()
	{
		return null;
	}

	[Token(Token = "0x6009D1E")]
	[Address(RVA = "0x30175D0", Offset = "0x30175D0", VA = "0x30175D0", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009D1F")]
	[Address(RVA = "0x3017744", Offset = "0x3017744", VA = "0x3017744", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
