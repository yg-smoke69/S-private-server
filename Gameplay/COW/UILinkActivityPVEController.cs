using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002188")]
public class UILinkActivityPVEController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002189")]
	private class CollectionInfo
	{
		[Token(Token = "0x400D254")]
		[FieldOffset(Offset = "0x8")]
		public ulong targetCount;

		[Token(Token = "0x400D255")]
		[FieldOffset(Offset = "0x10")]
		public uint processID;

		[Token(Token = "0x400D256")]
		[FieldOffset(Offset = "0x14")]
		public ENUM_CollectionState state;

		[Token(Token = "0x600B1F5")]
		[Address(RVA = "0x2556F28", Offset = "0x2556F28", VA = "0x2556F28")]
		public CollectionInfo()
		{
		}
	}

	[Token(Token = "0x200218A")]
	private sealed class _003CStartAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D257")]
		[FieldOffset(Offset = "0x8")]
		internal UILinkActivityPVEController _0024this;

		[Token(Token = "0x400D258")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D259")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D25A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001022")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B1F8")]
			[Address(RVA = "0x2557ECC", Offset = "0x2557ECC", VA = "0x2557ECC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001023")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B1F9")]
			[Address(RVA = "0x2557ED4", Offset = "0x2557ED4", VA = "0x2557ED4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B1F6")]
		[Address(RVA = "0x2557BF4", Offset = "0x2557BF4", VA = "0x2557BF4")]
		public _003CStartAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B1F7")]
		[Address(RVA = "0x2557CAC", Offset = "0x2557CAC", VA = "0x2557CAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B1FA")]
		[Address(RVA = "0x2557EDC", Offset = "0x2557EDC", VA = "0x2557EDC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B1FB")]
		[Address(RVA = "0x2557EF0", Offset = "0x2557EF0", VA = "0x2557EF0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D246")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint Const_OpenGameProcessID;

	[Token(Token = "0x400D247")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint Const_MAXEPCount;

	[Token(Token = "0x400D248")]
	private const uint GloabEPLeaderBoard = 4112u;

	[Token(Token = "0x400D249")]
	[FieldOffset(Offset = "0x28")]
	private UILinkActivityPVEView m_View;

	[Token(Token = "0x400D24A")]
	[FieldOffset(Offset = "0x2C")]
	protected UIModelLinkActivity m_Model;

	[Token(Token = "0x400D24B")]
	[FieldOffset(Offset = "0x30")]
	private UIModelLeaderBoard m_LeaderBoardModel;

	[Token(Token = "0x400D24C")]
	[FieldOffset(Offset = "0x34")]
	private LinkActivityData m_ActivityData;

	[Token(Token = "0x400D24D")]
	[FieldOffset(Offset = "0x38")]
	private List<UILinkActivityPVECollectionItem> m_CollectionUIItems;

	[Token(Token = "0x400D24E")]
	[FieldOffset(Offset = "0x3C")]
	private List<CollectionInfo> m_CollectionDatas;

	[Token(Token = "0x400D24F")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_CurrentEPCount;

	[Token(Token = "0x400D250")]
	[FieldOffset(Offset = "0x48")]
	public Action m_SwitchToGameStartCallBack;

	[Token(Token = "0x400D251")]
	[FieldOffset(Offset = "0x4C")]
	private List<uint> m_AllPendingClamIProcessID;

	[Token(Token = "0x400D252")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurProgressValue;

	[Token(Token = "0x400D253")]
	[FieldOffset(Offset = "0x8")]
	private static Func<CollectionInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B1DD")]
	[Address(RVA = "0x2555214", Offset = "0x2555214", VA = "0x2555214")]
	public UILinkActivityPVEController()
	{
	}

	[Token(Token = "0x600B1DE")]
	[Address(RVA = "0x25552CC", Offset = "0x25552CC", VA = "0x25552CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B1DF")]
	[Address(RVA = "0x2555374", Offset = "0x2555374", VA = "0x2555374", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B1E0")]
	[Address(RVA = "0x25559CC", Offset = "0x25559CC", VA = "0x25559CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B1E1")]
	[Address(RVA = "0x2555A80", Offset = "0x2555A80", VA = "0x2555A80", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B1E2")]
	[Address(RVA = "0x2555B38", Offset = "0x2555B38", VA = "0x2555B38", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B1E3")]
	[Address(RVA = "0x25556EC", Offset = "0x25556EC", VA = "0x25556EC")]
	protected void InitActivityInfo()
	{
	}

	[Token(Token = "0x600B1E4")]
	[Address(RVA = "0x2556304", Offset = "0x2556304", VA = "0x2556304")]
	private void InitCollectionInfos()
	{
	}

	[Token(Token = "0x600B1E5")]
	[Address(RVA = "0x255682C", Offset = "0x255682C", VA = "0x255682C")]
	private void SetCollectionDatas()
	{
	}

	[Token(Token = "0x600B1E6")]
	[Address(RVA = "0x2556DB0", Offset = "0x2556DB0", VA = "0x2556DB0")]
	private void SetCollectionUIItems(int itemNum)
	{
	}

	[Token(Token = "0x600B1E7")]
	[Address(RVA = "0x25571C0", Offset = "0x25571C0", VA = "0x25571C0")]
	private void UpdateCollectionItem(int index, CollectionInfo info)
	{
	}

	[Token(Token = "0x600B1E8")]
	[Address(RVA = "0x2556F30", Offset = "0x2556F30", VA = "0x2556F30")]
	private void CreateCollectionItem(int index)
	{
	}

	[Token(Token = "0x600B1E9")]
	[Address(RVA = "0x25565C8", Offset = "0x25565C8", VA = "0x25565C8")]
	private void UpdateProgressLayer()
	{
	}

	[Token(Token = "0x600B1EA")]
	[Address(RVA = "0x25563D8", Offset = "0x25563D8", VA = "0x25563D8")]
	private void UpdateEPCount()
	{
	}

	[Token(Token = "0x600B1EB")]
	[Address(RVA = "0x2555CEC", Offset = "0x2555CEC", VA = "0x2555CEC")]
	private void UpdataRankUIS()
	{
	}

	[Token(Token = "0x600B1EC")]
	[Address(RVA = "0x2557584", Offset = "0x2557584", VA = "0x2557584")]
	private void OnCollectionClick(uint processID)
	{
	}

	[Token(Token = "0x600B1ED")]
	[Address(RVA = "0x25578E0", Offset = "0x25578E0", VA = "0x25578E0")]
	private void ShowConfirmWindow()
	{
	}

	[Token(Token = "0x600B1EE")]
	[Address(RVA = "0x2557AA8", Offset = "0x2557AA8", VA = "0x2557AA8")]
	private void OnConfirmBatchClaim()
	{
	}

	[Token(Token = "0x600B1EF")]
	[Address(RVA = "0x2555C7C", Offset = "0x2555C7C", VA = "0x2555C7C")]
	private void BeginSwitchToStartGamePage()
	{
	}

	[Token(Token = "0x600B1F0")]
	[Address(RVA = "0x2557B28", Offset = "0x2557B28", VA = "0x2557B28")]
	private IEnumerator StartAnim()
	{
		return null;
	}

	[Token(Token = "0x600B1F2")]
	[Address(RVA = "0x2557C78", Offset = "0x2557C78", VA = "0x2557C78")]
	private static ulong _003CSetCollectionDatas_003Em__0(CollectionInfo u)
	{
		return default(ulong);
	}

	[Token(Token = "0x600B1F3")]
	[Address(RVA = "0x2557C9C", Offset = "0x2557C9C", VA = "0x2557C9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B1F4")]
	[Address(RVA = "0x2557CA4", Offset = "0x2557CA4", VA = "0x2557CA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
