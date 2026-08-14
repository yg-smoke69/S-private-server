using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021CB")]
public class UIInstallmentMallPurchaseItemController : UIEasyListItemController
{
	[Token(Token = "0x20021CC")]
	private class Term
	{
		[Token(Token = "0x400D35F")]
		[FieldOffset(Offset = "0x8")]
		protected UIInstallmentMallPurchaseItemView m_View;

		[Token(Token = "0x400D360")]
		[FieldOffset(Offset = "0xC")]
		protected InstallmentStoreDesc m_Desc;

		[Token(Token = "0x400D361")]
		[FieldOffset(Offset = "0x10")]
		protected Item m_Item;

		[Token(Token = "0x400D362")]
		[FieldOffset(Offset = "0x14")]
		protected UIModelMall m_ModelMall;

		[Token(Token = "0x400D363")]
		[FieldOffset(Offset = "0x18")]
		protected int m_Index;

		[Token(Token = "0x400D364")]
		[FieldOffset(Offset = "0x1C")]
		protected bool m_IsCurrentTerm;

		[Token(Token = "0x400D365")]
		[FieldOffset(Offset = "0x1D")]
		protected bool m_IsPreviousTerm;

		[Token(Token = "0x400D366")]
		[FieldOffset(Offset = "0x20")]
		protected uint m_CurrentTerm;

		[Token(Token = "0x400D367")]
		private const uint TERMLOCKCOLOR = 3154116863u;

		[Token(Token = "0x400D368")]
		private const uint TERMNORMALCOLOR = 4139391487u;

		[Token(Token = "0x600B4FE")]
		[Address(RVA = "0x127EFDC", Offset = "0x127EFDC", VA = "0x127EFDC")]
		public Term()
		{
		}

		[Token(Token = "0x600B4FF")]
		[Address(RVA = "0x127E988", Offset = "0x127E988", VA = "0x127E988")]
		public void SetData(UIInstallmentMallPurchaseItemView view, InstallmentStoreDesc desc, Item item, int index)
		{
		}

		[Token(Token = "0x600B500")]
		[Address(RVA = "0x127EB1C", Offset = "0x127EB1C", VA = "0x127EB1C")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x600B501")]
		[Address(RVA = "0x127F244", Offset = "0x127F244", VA = "0x127F244", Slot = "4")]
		protected virtual void OnRefreshView()
		{
		}

		[Token(Token = "0x600B502")]
		[Address(RVA = "0x127F9A0", Offset = "0x127F9A0", VA = "0x127F9A0")]
		private void HideUI()
		{
		}
	}

	[Token(Token = "0x20021CD")]
	private class FirstTerm : Term
	{
		[Token(Token = "0x600B503")]
		[Address(RVA = "0x127E730", Offset = "0x127E730", VA = "0x127E730")]
		public FirstTerm()
		{
		}

		[Token(Token = "0x600B504")]
		[Address(RVA = "0x127EFE4", Offset = "0x127EFE4", VA = "0x127EFE4", Slot = "4")]
		protected override void OnRefreshView()
		{
		}

		[Token(Token = "0x600B505")]
		[Address(RVA = "0x127F240", Offset = "0x127F240", VA = "0x127F240")]
		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}
	}

	[Token(Token = "0x20021CE")]
	private class NormalTerm : Term
	{
		[Token(Token = "0x600B506")]
		[Address(RVA = "0x127E738", Offset = "0x127E738", VA = "0x127E738")]
		public NormalTerm()
		{
		}

		[Token(Token = "0x600B507")]
		[Address(RVA = "0x127F648", Offset = "0x127F648", VA = "0x127F648", Slot = "4")]
		protected override void OnRefreshView()
		{
		}

		[Token(Token = "0x600B508")]
		[Address(RVA = "0x127F99C", Offset = "0x127F99C", VA = "0x127F99C")]
		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}
	}

	[Token(Token = "0x20021CF")]
	private class LastTerm : Term
	{
		[Token(Token = "0x600B509")]
		[Address(RVA = "0x127E740", Offset = "0x127E740", VA = "0x127E740")]
		public LastTerm()
		{
		}

		[Token(Token = "0x600B50A")]
		[Address(RVA = "0x127F298", Offset = "0x127F298", VA = "0x127F298", Slot = "4")]
		protected override void OnRefreshView()
		{
		}

		[Token(Token = "0x600B50B")]
		[Address(RVA = "0x127F644", Offset = "0x127F644", VA = "0x127F644")]
		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}
	}

	[Token(Token = "0x400D356")]
	[FieldOffset(Offset = "0x38")]
	private UIInstallmentMallPurchaseItemView m_View;

	[Token(Token = "0x400D357")]
	[FieldOffset(Offset = "0x3C")]
	private InstallmentStoreDesc m_StoreDesc;

	[Token(Token = "0x400D358")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D359")]
	[FieldOffset(Offset = "0x44")]
	private Item m_Item;

	[Token(Token = "0x400D35A")]
	[FieldOffset(Offset = "0x48")]
	private int m_Index;

	[Token(Token = "0x400D35B")]
	[FieldOffset(Offset = "0x4C")]
	private Term m_Term;

	[Token(Token = "0x400D35C")]
	[FieldOffset(Offset = "0x50")]
	private FirstTerm m_FirstTerm;

	[Token(Token = "0x400D35D")]
	[FieldOffset(Offset = "0x54")]
	private NormalTerm m_NormalTerm;

	[Token(Token = "0x400D35E")]
	[FieldOffset(Offset = "0x58")]
	private LastTerm m_LastTerm;

	[Token(Token = "0x600B4F7")]
	[Address(RVA = "0x127E428", Offset = "0x127E428", VA = "0x127E428")]
	public UIInstallmentMallPurchaseItemController()
	{
	}

	[Token(Token = "0x600B4F8")]
	[Address(RVA = "0x127E430", Offset = "0x127E430", VA = "0x127E430")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4F9")]
	[Address(RVA = "0x127E4D8", Offset = "0x127E4D8", VA = "0x127E4D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B4FA")]
	[Address(RVA = "0x127E60C", Offset = "0x127E60C", VA = "0x127E60C")]
	private void InitTerm()
	{
	}

	[Token(Token = "0x600B4FB")]
	[Address(RVA = "0x127E748", Offset = "0x127E748", VA = "0x127E748", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B4FC")]
	[Address(RVA = "0x127E884", Offset = "0x127E884", VA = "0x127E884")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B4FD")]
	[Address(RVA = "0x127EFD4", Offset = "0x127EFD4", VA = "0x127EFD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
