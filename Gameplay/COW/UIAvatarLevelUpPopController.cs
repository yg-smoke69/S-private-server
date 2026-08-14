using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024AB")]
public class UIAvatarLevelUpPopController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20024AC")]
	private sealed class _003CPlayTextAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E339")]
		[FieldOffset(Offset = "0x8")]
		internal int oldnum;

		[Token(Token = "0x400E33A")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Cnownum_003E__0;

		[Token(Token = "0x400E33B")]
		[FieldOffset(Offset = "0x10")]
		internal int newnum;

		[Token(Token = "0x400E33C")]
		[FieldOffset(Offset = "0x14")]
		internal int delta;

		[Token(Token = "0x400E33D")]
		[FieldOffset(Offset = "0x18")]
		internal UIAvatarLevelUpPopController _0024this;

		[Token(Token = "0x400E33E")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400E33F")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400E340")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001122")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D1FE")]
			[Address(RVA = "0x2A871AC", Offset = "0x2A871AC", VA = "0x2A871AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001123")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D1FF")]
			[Address(RVA = "0x2A871B4", Offset = "0x2A871B4", VA = "0x2A871B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D1FC")]
		[Address(RVA = "0x2A8609C", Offset = "0x2A8609C", VA = "0x2A8609C")]
		public _003CPlayTextAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D1FD")]
		[Address(RVA = "0x2A8708C", Offset = "0x2A8708C", VA = "0x2A8708C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D200")]
		[Address(RVA = "0x2A871BC", Offset = "0x2A871BC", VA = "0x2A871BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D201")]
		[Address(RVA = "0x2A871D0", Offset = "0x2A871D0", VA = "0x2A871D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E32C")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarLevelUpPopView m_View;

	[Token(Token = "0x400E32D")]
	[FieldOffset(Offset = "0x4C")]
	private UIAvatarSkillSlotController slotctrl;

	[Token(Token = "0x400E32E")]
	[FieldOffset(Offset = "0x50")]
	private uint MaxSkillLevel;

	[Token(Token = "0x400E32F")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsMaxLevel;

	[Token(Token = "0x400E330")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentNeedDebrisCout;

	[Token(Token = "0x400E331")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_CurrentHasDebrisCout;

	[Token(Token = "0x400E332")]
	[FieldOffset(Offset = "0x60")]
	private uint buyid;

	[Token(Token = "0x400E333")]
	[FieldOffset(Offset = "0x64")]
	private uint m_AvatarId;

	[Token(Token = "0x400E334")]
	[FieldOffset(Offset = "0x68")]
	private AvatarSkillData m_SkillData;

	[Token(Token = "0x400E335")]
	[FieldOffset(Offset = "0x6C")]
	private uint derbisID;

	[Token(Token = "0x400E336")]
	[FieldOffset(Offset = "0x70")]
	private Color passive;

	[Token(Token = "0x400E337")]
	[FieldOffset(Offset = "0x80")]
	private List<UIAvatarLevelUpItemController> m_LevelUpList;

	[Token(Token = "0x400E338")]
	[FieldOffset(Offset = "0x88")]
	private ulong mytime;

	[Token(Token = "0x600D1DE")]
	[Address(RVA = "0x2A81690", Offset = "0x2A81690", VA = "0x2A81690")]
	public UIAvatarLevelUpPopController()
	{
	}

	[Token(Token = "0x600D1DF")]
	[Address(RVA = "0x2A81784", Offset = "0x2A81784", VA = "0x2A81784", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x600D1E0")]
	[Address(RVA = "0x2A81828", Offset = "0x2A81828", VA = "0x2A81828")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1E1")]
	[Address(RVA = "0x2A818D0", Offset = "0x2A818D0", VA = "0x2A818D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1E2")]
	[Address(RVA = "0x2A81D5C", Offset = "0x2A81D5C", VA = "0x2A81D5C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D1E3")]
	[Address(RVA = "0x2A823C4", Offset = "0x2A823C4", VA = "0x2A823C4")]
	private void OnDebrisClick()
	{
	}

	[Token(Token = "0x600D1E4")]
	[Address(RVA = "0x2A82574", Offset = "0x2A82574", VA = "0x2A82574")]
	private void OnUnDeBrisClick()
	{
	}

	[Token(Token = "0x600D1E5")]
	[Address(RVA = "0x2A82718", Offset = "0x2A82718", VA = "0x2A82718")]
	private void OnLevelClick()
	{
	}

	[Token(Token = "0x600D1E6")]
	[Address(RVA = "0x2A831F8", Offset = "0x2A831F8", VA = "0x2A831F8", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600D1E7")]
	[Address(RVA = "0x2A83250", Offset = "0x2A83250", VA = "0x2A83250")]
	private void OntipsCLick()
	{
	}

	[Token(Token = "0x600D1E8")]
	[Address(RVA = "0x2A835C4", Offset = "0x2A835C4", VA = "0x2A835C4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1E9")]
	[Address(RVA = "0x2A83788", Offset = "0x2A83788", VA = "0x2A83788")]
	private void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x600D1EA")]
	[Address(RVA = "0x2A839B4", Offset = "0x2A839B4", VA = "0x2A839B4")]
	private void OnUpdateInfo(object[] data)
	{
	}

	[Token(Token = "0x600D1EB")]
	[Address(RVA = "0x2A83EC8", Offset = "0x2A83EC8", VA = "0x2A83EC8")]
	private void PlayMaxLevelVfx()
	{
	}

	[Token(Token = "0x600D1EC")]
	[Address(RVA = "0x2A85E30", Offset = "0x2A85E30", VA = "0x2A85E30")]
	private void StartPlayAnimationText(int oldnum, int nownum)
	{
	}

	[Token(Token = "0x600D1ED")]
	[Address(RVA = "0x2A85F6C", Offset = "0x2A85F6C", VA = "0x2A85F6C")]
	private IEnumerator PlayTextAnimation(int oldnum, int newnum, int delta)
	{
		return null;
	}

	[Token(Token = "0x600D1EE")]
	[Address(RVA = "0x2A860A4", Offset = "0x2A860A4", VA = "0x2A860A4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D1EF")]
	[Address(RVA = "0x2A86310", Offset = "0x2A86310", VA = "0x2A86310")]
	private void RefreshDebrisCout()
	{
	}

	[Token(Token = "0x600D1F0")]
	[Address(RVA = "0x2A86188", Offset = "0x2A86188", VA = "0x2A86188")]
	private void RefreshOwnCount()
	{
	}

	[Token(Token = "0x600D1F1")]
	[Address(RVA = "0x2A86A7C", Offset = "0x2A86A7C", VA = "0x2A86A7C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D1F2")]
	[Address(RVA = "0x2A83F1C", Offset = "0x2A83F1C", VA = "0x2A83F1C")]
	public void RefreshData(AvatarSkillData skilldata, bool playanimation = false)
	{
	}

	[Token(Token = "0x600D1F3")]
	[Address(RVA = "0x2A867E4", Offset = "0x2A867E4", VA = "0x2A867E4")]
	private uint GetAvatarDebrisLockCout(uint avatarid, uint level)
	{
		return default(uint);
	}

	[Token(Token = "0x600D1F4")]
	[Address(RVA = "0x2A86B10", Offset = "0x2A86B10", VA = "0x2A86B10")]
	private uint GetAvatarIdBySkillId(uint _skillid)
	{
		return default(uint);
	}

	[Token(Token = "0x600D1F5")]
	[Address(RVA = "0x2A86DB4", Offset = "0x2A86DB4", VA = "0x2A86DB4", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600D1F6")]
	[Address(RVA = "0x2A8705C", Offset = "0x2A8705C", VA = "0x2A8705C")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x600D1F7")]
	[Address(RVA = "0x2A87064", Offset = "0x2A87064", VA = "0x2A87064")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1F8")]
	[Address(RVA = "0x2A8706C", Offset = "0x2A8706C", VA = "0x2A8706C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D1F9")]
	[Address(RVA = "0x2A87074", Offset = "0x2A87074", VA = "0x2A87074")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600D1FA")]
	[Address(RVA = "0x2A8707C", Offset = "0x2A8707C", VA = "0x2A8707C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D1FB")]
	[Address(RVA = "0x2A87084", Offset = "0x2A87084", VA = "0x2A87084")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
