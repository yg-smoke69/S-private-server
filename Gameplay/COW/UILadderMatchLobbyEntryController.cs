using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002161")]
public class UILadderMatchLobbyEntryController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002162")]
	private sealed class _003CShowRankingGuide_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D1AA")]
		[FieldOffset(Offset = "0x8")]
		internal string _003Cnewkey_003E__0;

		[Token(Token = "0x400D1AB")]
		[FieldOffset(Offset = "0xC")]
		internal UIPanel _003Cpanel_003E__0;

		[Token(Token = "0x400D1AC")]
		[FieldOffset(Offset = "0x10")]
		internal CommonGuideSetting _003Csetting_003E__0;

		[Token(Token = "0x400D1AD")]
		[FieldOffset(Offset = "0x14")]
		internal UILadderMatchLobbyEntryController _0024this;

		[Token(Token = "0x400D1AE")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D1AF")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D1B0")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700101F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B082")]
			[Address(RVA = "0x1AF61EC", Offset = "0x1AF61EC", VA = "0x1AF61EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001020")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B083")]
			[Address(RVA = "0x1AF61F4", Offset = "0x1AF61F4", VA = "0x1AF61F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B080")]
		[Address(RVA = "0x1AF5BF8", Offset = "0x1AF5BF8", VA = "0x1AF5BF8")]
		public _003CShowRankingGuide_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B081")]
		[Address(RVA = "0x1AF5C10", Offset = "0x1AF5C10", VA = "0x1AF5C10", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B084")]
		[Address(RVA = "0x1AF61FC", Offset = "0x1AF61FC", VA = "0x1AF61FC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B085")]
		[Address(RVA = "0x1AF6210", Offset = "0x1AF6210", VA = "0x1AF6210", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D1A5")]
	[FieldOffset(Offset = "0x28")]
	private LadderMatchLobbyEntryView m_View;

	[Token(Token = "0x400D1A6")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLadderMatch m_LadderModel;

	[Token(Token = "0x400D1A7")]
	[FieldOffset(Offset = "0x30")]
	private UIModelInventory m_InventoryModel;

	[Token(Token = "0x400D1A8")]
	[FieldOffset(Offset = "0x34")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x400D1A9")]
	[FieldOffset(Offset = "0x38")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x600B073")]
	[Address(RVA = "0x1AF3E9C", Offset = "0x1AF3E9C", VA = "0x1AF3E9C")]
	public UILadderMatchLobbyEntryController()
	{
	}

	[Token(Token = "0x600B074")]
	[Address(RVA = "0x1AF3F20", Offset = "0x1AF3F20", VA = "0x1AF3F20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B075")]
	[Address(RVA = "0x1AF3FC4", Offset = "0x1AF3FC4", VA = "0x1AF3FC4", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B076")]
	[Address(RVA = "0x1AF407C", Offset = "0x1AF407C", VA = "0x1AF407C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B077")]
	[Address(RVA = "0x1AF4BC8", Offset = "0x1AF4BC8", VA = "0x1AF4BC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B078")]
	[Address(RVA = "0x1AF51EC", Offset = "0x1AF51EC", VA = "0x1AF51EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B079")]
	[Address(RVA = "0x1AF5388", Offset = "0x1AF5388", VA = "0x1AF5388")]
	private void CloseGuide()
	{
	}

	[Token(Token = "0x600B07A")]
	[Address(RVA = "0x1AF548C", Offset = "0x1AF548C", VA = "0x1AF548C")]
	private void OnEntryClick()
	{
	}

	[Token(Token = "0x600B07B")]
	[Address(RVA = "0x1AF43AC", Offset = "0x1AF43AC", VA = "0x1AF43AC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B07C")]
	[Address(RVA = "0x1AF582C", Offset = "0x1AF582C", VA = "0x1AF582C")]
	private void RefreshOpeningUI()
	{
	}

	[Token(Token = "0x600B07D")]
	[Address(RVA = "0x1AF5B2C", Offset = "0x1AF5B2C", VA = "0x1AF5B2C")]
	private IEnumerator ShowRankingGuide()
	{
		return null;
	}

	[Token(Token = "0x600B07E")]
	[Address(RVA = "0x1AF5C00", Offset = "0x1AF5C00", VA = "0x1AF5C00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B07F")]
	[Address(RVA = "0x1AF5C08", Offset = "0x1AF5C08", VA = "0x1AF5C08")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
