using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024D5")]
public class UIAvatarSkillTipsController : UIBaseController
{
	[Token(Token = "0x20024D6")]
	private sealed class _003CRefreshNewState_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E46E")]
		[FieldOffset(Offset = "0x8")]
		internal UIAvatarSkillTipsController _0024this;

		[Token(Token = "0x400E46F")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E470")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E471")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001137")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D410")]
			[Address(RVA = "0x2FA0E64", Offset = "0x2FA0E64", VA = "0x2FA0E64", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001138")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D411")]
			[Address(RVA = "0x2FA0E6C", Offset = "0x2FA0E6C", VA = "0x2FA0E6C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D40E")]
		[Address(RVA = "0x2FA02F0", Offset = "0x2FA02F0", VA = "0x2FA02F0")]
		public _003CRefreshNewState_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D40F")]
		[Address(RVA = "0x2FA0308", Offset = "0x2FA0308", VA = "0x2FA0308", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D412")]
		[Address(RVA = "0x2FA0E74", Offset = "0x2FA0E74", VA = "0x2FA0E74", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D413")]
		[Address(RVA = "0x2FA0E88", Offset = "0x2FA0E88", VA = "0x2FA0E88", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E465")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarSkillTipsView m_View;

	[Token(Token = "0x400E466")]
	[FieldOffset(Offset = "0x2C")]
	private List<AvatarSkillData> m_List;

	[Token(Token = "0x400E467")]
	[FieldOffset(Offset = "0x30")]
	private int m_skillLength;

	[Token(Token = "0x400E468")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_Pos;

	[Token(Token = "0x400E469")]
	[FieldOffset(Offset = "0x40")]
	private bool m_StayInCenter;

	[Token(Token = "0x400E46A")]
	[FieldOffset(Offset = "0x44")]
	private Color32 Yellow;

	[Token(Token = "0x400E46B")]
	[FieldOffset(Offset = "0x48")]
	private Color32 Blue;

	[Token(Token = "0x400E46C")]
	[FieldOffset(Offset = "0x4C")]
	private Color32 Green;

	[Token(Token = "0x400E46D")]
	[FieldOffset(Offset = "0x50")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x600D401")]
	[Address(RVA = "0x2F9F570", Offset = "0x2F9F570", VA = "0x2F9F570")]
	public UIAvatarSkillTipsController()
	{
	}

	[Token(Token = "0x600D402")]
	[Address(RVA = "0x2F9F67C", Offset = "0x2F9F67C", VA = "0x2F9F67C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D403")]
	[Address(RVA = "0x2F9F724", Offset = "0x2F9F724", VA = "0x2F9F724", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D404")]
	[Address(RVA = "0x2F9FA1C", Offset = "0x2F9FA1C", VA = "0x2F9FA1C")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600D405")]
	[Address(RVA = "0x2F9495C", Offset = "0x2F9495C", VA = "0x2F9495C")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600D406")]
	[Address(RVA = "0x2F9FA80", Offset = "0x2F9FA80", VA = "0x2F9FA80", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D407")]
	[Address(RVA = "0x2F9FC00", Offset = "0x2F9FC00", VA = "0x2F9FC00")]
	private void _OnClose(object[] data)
	{
	}

	[Token(Token = "0x600D408")]
	[Address(RVA = "0x2F95C2C", Offset = "0x2F95C2C", VA = "0x2F95C2C")]
	public void RefreshLevel(int level)
	{
	}

	[Token(Token = "0x600D409")]
	[Address(RVA = "0x2F949F4", Offset = "0x2F949F4", VA = "0x2F949F4")]
	public void RefreshData(Vector3 worldPosition, AvatarSkillData data, bool stayInCenter = false)
	{
	}

	[Token(Token = "0x600D40A")]
	[Address(RVA = "0x2FA0154", Offset = "0x2FA0154", VA = "0x2FA0154")]
	private int GetTypeByPos(Vector3 pos)
	{
		return default(int);
	}

	[Token(Token = "0x600D40B")]
	[Address(RVA = "0x2FA0088", Offset = "0x2FA0088", VA = "0x2FA0088")]
	private IEnumerator RefreshNewState()
	{
		return null;
	}

	[Token(Token = "0x600D40C")]
	[Address(RVA = "0x2FA02F8", Offset = "0x2FA02F8", VA = "0x2FA02F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D40D")]
	[Address(RVA = "0x2FA0300", Offset = "0x2FA0300", VA = "0x2FA0300")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
