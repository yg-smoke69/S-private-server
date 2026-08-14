using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026D2")]
public class UIHUDAOHKillPointsController : UIBaseController
{
	[Token(Token = "0x20026D3")]
	private sealed class _003CIEPointsUpAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EFEB")]
		[FieldOffset(Offset = "0x8")]
		internal BigHeadData _003Cdata_003E__1;

		[Token(Token = "0x400EFEC")]
		[FieldOffset(Offset = "0xC")]
		internal UIHUDAOHKillPointsController _0024this;

		[Token(Token = "0x400EFED")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400EFEE")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400EFEF")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EAE2")]
			[Address(RVA = "0x166B47C", Offset = "0x166B47C", VA = "0x166B47C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EAE3")]
			[Address(RVA = "0x166B484", Offset = "0x166B484", VA = "0x166B484", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EAE0")]
		[Address(RVA = "0x166AE84", Offset = "0x166AE84", VA = "0x166AE84")]
		public _003CIEPointsUpAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EAE1")]
		[Address(RVA = "0x166AFBC", Offset = "0x166AFBC", VA = "0x166AFBC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EAE4")]
		[Address(RVA = "0x166B48C", Offset = "0x166B48C", VA = "0x166B48C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EAE5")]
		[Address(RVA = "0x166B4A0", Offset = "0x166B4A0", VA = "0x166B4A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EFE2")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDAOHKillPointsView m_View;

	[Token(Token = "0x400EFE3")]
	[FieldOffset(Offset = "0x2C")]
	private int m_KillPoints;

	[Token(Token = "0x400EFE4")]
	[FieldOffset(Offset = "0x30")]
	private int m_Level;

	[Token(Token = "0x400EFE5")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurShowLevel;

	[Token(Token = "0x400EFE6")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurShowPoint;

	[Token(Token = "0x400EFE7")]
	[FieldOffset(Offset = "0x3C")]
	private Coroutine m_AnimHandle;

	[Token(Token = "0x400EFE8")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsPlayingPointUpAnim;

	[Token(Token = "0x400EFE9")]
	[FieldOffset(Offset = "0x44")]
	protected BigHeadDataConfig m_BigHeadDataConfig;

	[Token(Token = "0x400EFEA")]
	[FieldOffset(Offset = "0x48")]
	private List<UIHUDArmsRacePointItem> m_PointItems;

	[Token(Token = "0x600EAD5")]
	[Address(RVA = "0x166A360", Offset = "0x166A360", VA = "0x166A360")]
	public UIHUDAOHKillPointsController()
	{
	}

	[Token(Token = "0x600EAD6")]
	[Address(RVA = "0x166A418", Offset = "0x166A418", VA = "0x166A418")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAD7")]
	[Address(RVA = "0x166A4C0", Offset = "0x166A4C0", VA = "0x166A4C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EAD8")]
	[Address(RVA = "0x166AB14", Offset = "0x166AB14", VA = "0x166AB14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EAD9")]
	[Address(RVA = "0x166AC48", Offset = "0x166AC48", VA = "0x166AC48")]
	private void OnPlayerLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600EADA")]
	[Address(RVA = "0x166AD34", Offset = "0x166AD34", VA = "0x166AD34")]
	private void PlayPointsUpAnim()
	{
	}

	[Token(Token = "0x600EADB")]
	[Address(RVA = "0x166ADB8", Offset = "0x166ADB8", VA = "0x166ADB8")]
	private IEnumerator IEPointsUpAnim()
	{
		return null;
	}

	[Token(Token = "0x600EADC")]
	[Address(RVA = "0x166AE8C", Offset = "0x166AE8C", VA = "0x166AE8C")]
	private void LightingKillPoint(int index)
	{
	}

	[Token(Token = "0x600EADD")]
	[Address(RVA = "0x166A6FC", Offset = "0x166A6FC", VA = "0x166A6FC")]
	private void PrepareShowLevelEmptyPoint(int showLevel)
	{
	}

	[Token(Token = "0x600EADE")]
	[Address(RVA = "0x166AFAC", Offset = "0x166AFAC", VA = "0x166AFAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EADF")]
	[Address(RVA = "0x166AFB4", Offset = "0x166AFB4", VA = "0x166AFB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
