using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200273E")]
internal class UIHudEscortBossNameController : UIBaseController
{
	[Token(Token = "0x200273F")]
	private enum EArrowDirection
	{
		[Token(Token = "0x400F233")]
		NONE,
		[Token(Token = "0x400F234")]
		UP,
		[Token(Token = "0x400F235")]
		DOWN,
		[Token(Token = "0x400F236")]
		LEFT,
		[Token(Token = "0x400F237")]
		RIGHT
	}

	[Token(Token = "0x2002740")]
	private sealed class _003CRemoveNameInfo_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F238")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400F239")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudEscortBossNameController _0024this;

		[Token(Token = "0x400F23A")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400F23B")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400F23C")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011BC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EF5E")]
			[Address(RVA = "0x1B918F0", Offset = "0x1B918F0", VA = "0x1B918F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EF5F")]
			[Address(RVA = "0x1B918F8", Offset = "0x1B918F8", VA = "0x1B918F8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EF5C")]
		[Address(RVA = "0x1B917F0", Offset = "0x1B917F0", VA = "0x1B917F0")]
		public _003CRemoveNameInfo_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EF5D")]
		[Address(RVA = "0x1B917F8", Offset = "0x1B917F8", VA = "0x1B917F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EF60")]
		[Address(RVA = "0x1B91900", Offset = "0x1B91900", VA = "0x1B91900", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EF61")]
		[Address(RVA = "0x1B91914", Offset = "0x1B91914", VA = "0x1B91914", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F22A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortBossNameView m_View;

	[Token(Token = "0x400F22B")]
	[FieldOffset(Offset = "0x2C")]
	private Camera m_FollowCamera;

	[Token(Token = "0x400F22C")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_UICamera;

	[Token(Token = "0x400F22D")]
	[FieldOffset(Offset = "0x34")]
	private StringBuilder m_Distance;

	[Token(Token = "0x400F22E")]
	[FieldOffset(Offset = "0x38")]
	private int m_PrevDistance;

	[Token(Token = "0x400F22F")]
	[FieldOffset(Offset = "0x3C")]
	private float viewPortBoundary;

	[Token(Token = "0x400F230")]
	[FieldOffset(Offset = "0x40")]
	private LevelEscortMatchBoss m_Boss;

	[Token(Token = "0x400F231")]
	private const float ARROW_ICON_HALF_SIZE = 21f;

	[Token(Token = "0x600EF42")]
	[Address(RVA = "0x1CE6548", Offset = "0x1CE6548", VA = "0x1CE6548")]
	public UIHudEscortBossNameController()
	{
	}

	[Token(Token = "0x600EF43")]
	[Address(RVA = "0x1CE65D4", Offset = "0x1CE65D4", VA = "0x1CE65D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF44")]
	[Address(RVA = "0x1CE6678", Offset = "0x1CE6678", VA = "0x1CE6678", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF45")]
	[Address(RVA = "0x1CE6F0C", Offset = "0x1CE6F0C", VA = "0x1CE6F0C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EF46")]
	[Address(RVA = "0x1CE7168", Offset = "0x1CE7168", VA = "0x1CE7168")]
	private void InitCamera()
	{
	}

	[Token(Token = "0x600EF47")]
	[Address(RVA = "0x1CE73A4", Offset = "0x1CE73A4", VA = "0x1CE73A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EF48")]
	[Address(RVA = "0x1CE760C", Offset = "0x1CE760C", VA = "0x1CE760C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EF49")]
	[Address(RVA = "0x1CE7670", Offset = "0x1CE7670", VA = "0x1CE7670")]
	private void OnWheelHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF4A")]
	[Address(RVA = "0x1CE7880", Offset = "0x1CE7880", VA = "0x1CE7880")]
	private void OnBodyHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF4B")]
	[Address(RVA = "0x1CE7A90", Offset = "0x1CE7A90", VA = "0x1CE7A90")]
	private void OnVehicleStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF4C")]
	[Address(RVA = "0x1CE6DAC", Offset = "0x1CE6DAC", VA = "0x1CE6DAC")]
	private void UpdateRepairStatus()
	{
	}

	[Token(Token = "0x600EF4D")]
	[Address(RVA = "0x1CE76D8", Offset = "0x1CE76D8", VA = "0x1CE76D8")]
	private void UpdateWheelHPUI()
	{
	}

	[Token(Token = "0x600EF4E")]
	[Address(RVA = "0x1CE78E8", Offset = "0x1CE78E8", VA = "0x1CE78E8")]
	private void UpdateBodyHPUI()
	{
	}

	[Token(Token = "0x600EF4F")]
	[Address(RVA = "0x1CE7AF8", Offset = "0x1CE7AF8", VA = "0x1CE7AF8")]
	private void SetContainerActive(bool active)
	{
	}

	[Token(Token = "0x600EF50")]
	[Address(RVA = "0x1CE7B90", Offset = "0x1CE7B90", VA = "0x1CE7B90")]
	public void BindTarget(LevelEscortMatchBoss boss)
	{
	}

	[Token(Token = "0x600EF51")]
	[Address(RVA = "0x1CE7C04", Offset = "0x1CE7C04", VA = "0x1CE7C04")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600EF52")]
	[Address(RVA = "0x1CE7CE8", Offset = "0x1CE7CE8", VA = "0x1CE7CE8")]
	private void UpdateNamePosition()
	{
	}

	[Token(Token = "0x600EF53")]
	[Address(RVA = "0x1CE8738", Offset = "0x1CE8738", VA = "0x1CE8738")]
	private void SetDistance(int distance)
	{
	}

	[Token(Token = "0x600EF54")]
	[Address(RVA = "0x1CE86B4", Offset = "0x1CE86B4", VA = "0x1CE86B4")]
	private Vector3 GetRefPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF55")]
	[Address(RVA = "0x1CE88F0", Offset = "0x1CE88F0", VA = "0x1CE88F0")]
	private void SetViewActive(GameObject obj, bool active)
	{
	}

	[Token(Token = "0x600EF56")]
	[Address(RVA = "0x1CE68F8", Offset = "0x1CE68F8", VA = "0x1CE68F8")]
	private void ShowArrow(EArrowDirection direction)
	{
	}

	[Token(Token = "0x600EF57")]
	[Address(RVA = "0x1CE8A5C", Offset = "0x1CE8A5C", VA = "0x1CE8A5C")]
	private IEnumerator RemoveNameInfo(float delayTime)
	{
		return null;
	}

	[Token(Token = "0x600EF58")]
	[Address(RVA = "0x1CE8B58", Offset = "0x1CE8B58", VA = "0x1CE8B58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF59")]
	[Address(RVA = "0x1CE8B60", Offset = "0x1CE8B60", VA = "0x1CE8B60")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EF5A")]
	[Address(RVA = "0x1CE8B68", Offset = "0x1CE8B68", VA = "0x1CE8B68")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EF5B")]
	[Address(RVA = "0x1CE8B70", Offset = "0x1CE8B70", VA = "0x1CE8B70")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
