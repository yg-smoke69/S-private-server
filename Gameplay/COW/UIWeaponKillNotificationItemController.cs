using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D1B")]
internal class UIWeaponKillNotificationItemController : UIBaseController
{
	[Token(Token = "0x2002D1C")]
	private sealed class _003CAllignCenter_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4011383")]
		[FieldOffset(Offset = "0x8")]
		internal UIWeaponKillNotificationItemController _0024this;

		[Token(Token = "0x4011384")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4011385")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4011386")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001357")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012DC8")]
			[Address(RVA = "0x10231E0", Offset = "0x10231E0", VA = "0x10231E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001358")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012DC9")]
			[Address(RVA = "0x10231E8", Offset = "0x10231E8", VA = "0x10231E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012DC6")]
		[Address(RVA = "0x1022078", Offset = "0x1022078", VA = "0x1022078")]
		public _003CAllignCenter_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012DC7")]
		[Address(RVA = "0x1022FEC", Offset = "0x1022FEC", VA = "0x1022FEC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012DCA")]
		[Address(RVA = "0x10231F0", Offset = "0x10231F0", VA = "0x10231F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012DCB")]
		[Address(RVA = "0x1023204", Offset = "0x1023204", VA = "0x1023204", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401137D")]
	[FieldOffset(Offset = "0x28")]
	private UIWeaponKillNotificationItemView m_View;

	[Token(Token = "0x401137E")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_Pending;

	[Token(Token = "0x401137F")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x4011380")]
	[FieldOffset(Offset = "0x34")]
	private Timer m_ShowupTimer;

	[Token(Token = "0x4011381")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<ResourceID, GameObject> m_GoEffects;

	[Token(Token = "0x4011382")]
	[FieldOffset(Offset = "0x3C")]
	private string m_KillVerbColor;

	[Token(Token = "0x6012DB1")]
	[Address(RVA = "0x101FD40", Offset = "0x101FD40", VA = "0x101FD40")]
	public UIWeaponKillNotificationItemController()
	{
	}

	[Token(Token = "0x6012DB2")]
	[Address(RVA = "0x101FDE8", Offset = "0x101FDE8", VA = "0x101FDE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012DB3")]
	[Address(RVA = "0x101FE90", Offset = "0x101FE90", VA = "0x101FE90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012DB4")]
	[Address(RVA = "0x102000C", Offset = "0x102000C", VA = "0x102000C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012DB5")]
	[Address(RVA = "0x1020070", Offset = "0x1020070", VA = "0x1020070", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012DB6")]
	[Address(RVA = "0x102018C", Offset = "0x102018C", VA = "0x102018C")]
	public bool IsActive(float gameTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6012DB7")]
	[Address(RVA = "0x1020250", Offset = "0x1020250", VA = "0x1020250")]
	public void SetActive(bool v)
	{
	}

	[Token(Token = "0x6012DB8")]
	[Address(RVA = "0x1020318", Offset = "0x1020318", VA = "0x1020318")]
	public void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}

	[Token(Token = "0x6012DB9")]
	[Address(RVA = "0x1021FAC", Offset = "0x1021FAC", VA = "0x1021FAC")]
	private IEnumerator AllignCenter()
	{
		return null;
	}

	[Token(Token = "0x6012DBA")]
	[Address(RVA = "0x1022080", Offset = "0x1022080", VA = "0x1022080")]
	public void ShowPreviewNotification(uint itemId, bool ignorePending = false)
	{
	}

	[Token(Token = "0x6012DBB")]
	[Address(RVA = "0x102245C", Offset = "0x102245C", VA = "0x102245C")]
	public void SetTweenStart(Vector3 pos)
	{
	}

	[Token(Token = "0x6012DBC")]
	[Address(RVA = "0x102250C", Offset = "0x102250C", VA = "0x102250C")]
	public void ResetNotification()
	{
	}

	[Token(Token = "0x6012DBD")]
	[Address(RVA = "0x1021E98", Offset = "0x1021E98", VA = "0x1021E98")]
	private void SetQualityBGBySkinId(uint itemId)
	{
	}

	[Token(Token = "0x6012DBE")]
	[Address(RVA = "0x1022644", Offset = "0x1022644", VA = "0x1022644")]
	private void SetQualityBG(int quality)
	{
	}

	[Token(Token = "0x6012DBF")]
	[Address(RVA = "0x1021A60", Offset = "0x1021A60", VA = "0x1021A60")]
	private void ShowSkinEffect(uint itemId, IHAAMHPPLMG killerId, bool ignoreKillId = false)
	{
	}

	[Token(Token = "0x6012DC0")]
	[Address(RVA = "0x1022AEC", Offset = "0x1022AEC", VA = "0x1022AEC")]
	private void ShowSkinEffectGo(ResourceID resId)
	{
	}

	[Token(Token = "0x6012DC1")]
	[Address(RVA = "0x10227B0", Offset = "0x10227B0", VA = "0x10227B0")]
	public bool ShowHandWeaponAnnounceEffect(IHAAMHPPLMG killerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6012DC2")]
	[Address(RVA = "0x1022FA8", Offset = "0x1022FA8", VA = "0x1022FA8")]
	private void _003CShowPreviewNotification_003Em__0()
	{
	}

	[Token(Token = "0x6012DC3")]
	[Address(RVA = "0x1022FD4", Offset = "0x1022FD4", VA = "0x1022FD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012DC4")]
	[Address(RVA = "0x1022FDC", Offset = "0x1022FDC", VA = "0x1022FDC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012DC5")]
	[Address(RVA = "0x1022FE4", Offset = "0x1022FE4", VA = "0x1022FE4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
