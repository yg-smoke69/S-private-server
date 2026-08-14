using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002775")]
internal class UIHudHurtHintController : UIBaseController
{
	[Token(Token = "0x2002776")]
	private enum PriorityWaringType
	{
		[Token(Token = "0x400F39B")]
		EWaringType_Invalid,
		[Token(Token = "0x400F39C")]
		EWaringType_FootStep,
		[Token(Token = "0x400F39D")]
		EWaringType_Fire
	}

	[Token(Token = "0x2002777")]
	private sealed class _003CRemoveHurtHint_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F39E")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400F39F")]
		[FieldOffset(Offset = "0xC")]
		internal ResourceID resourceID;

		[Token(Token = "0x400F3A0")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudHurtHintController _0024this;

		[Token(Token = "0x400F3A1")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400F3A2")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400F3A3")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170011C6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F1B1")]
			[Address(RVA = "0x1346644", Offset = "0x1346644", VA = "0x1346644", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F1B2")]
			[Address(RVA = "0x134664C", Offset = "0x134664C", VA = "0x134664C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F1AF")]
		[Address(RVA = "0x13461F8", Offset = "0x13461F8", VA = "0x13461F8")]
		public _003CRemoveHurtHint_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F1B0")]
		[Address(RVA = "0x1346550", Offset = "0x1346550", VA = "0x1346550", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F1B3")]
		[Address(RVA = "0x1346654", Offset = "0x1346654", VA = "0x1346654", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F1B4")]
		[Address(RVA = "0x1346668", Offset = "0x1346668", VA = "0x1346668", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F393")]
	[FieldOffset(Offset = "0x28")]
	private UIHudHurtHintView m_View;

	[Token(Token = "0x400F394")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<ResourceID, Queue> m_HurtHintsMap;

	[Token(Token = "0x400F395")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, Player> m_HintsDict;

	[Token(Token = "0x400F396")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudWarningHint> m_PriorityHintsList;

	[Token(Token = "0x400F397")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurrentPriority;

	[Token(Token = "0x400F398")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, ResourceID> m_PriorityHintResDict;

	[Token(Token = "0x400F399")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<IHAAMHPPLMG, float> m_ShotGunHitPlayers;

	[Token(Token = "0x600F196")]
	[Address(RVA = "0x1341124", Offset = "0x1341124", VA = "0x1341124")]
	public UIHudHurtHintController()
	{
	}

	[Token(Token = "0x600F197")]
	[Address(RVA = "0x13412B4", Offset = "0x13412B4", VA = "0x13412B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F198")]
	[Address(RVA = "0x1341358", Offset = "0x1341358", VA = "0x1341358", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F199")]
	[Address(RVA = "0x13418B8", Offset = "0x13418B8", VA = "0x13418B8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F19A")]
	[Address(RVA = "0x1341ACC", Offset = "0x1341ACC", VA = "0x1341ACC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F19B")]
	[Address(RVA = "0x1341F74", Offset = "0x1341F74", VA = "0x1341F74")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600F19C")]
	[Address(RVA = "0x1342B5C", Offset = "0x1342B5C", VA = "0x1342B5C")]
	private Quaternion CalcHintRotaion(Vector3 targetPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600F19D")]
	[Address(RVA = "0x1341940", Offset = "0x1341940", VA = "0x1341940")]
	private void Clear()
	{
	}

	[Token(Token = "0x600F19E")]
	[Address(RVA = "0x134315C", Offset = "0x134315C", VA = "0x134315C")]
	private void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600F19F")]
	[Address(RVA = "0x13431C4", Offset = "0x13431C4", VA = "0x13431C4")]
	private void OnEnemyFootStep(object[] data)
	{
	}

	[Token(Token = "0x600F1A0")]
	[Address(RVA = "0x1344188", Offset = "0x1344188", VA = "0x1344188")]
	private void OnEnemyFire(object[] data)
	{
	}

	[Token(Token = "0x600F1A1")]
	[Address(RVA = "0x13444B8", Offset = "0x13444B8", VA = "0x13444B8")]
	private void OnSomeoneStopFiring(object[] param)
	{
	}

	[Token(Token = "0x600F1A2")]
	[Address(RVA = "0x1344A9C", Offset = "0x1344A9C", VA = "0x1344A9C")]
	private void OnSomeObjectFiring(object[] param)
	{
	}

	[Token(Token = "0x600F1A3")]
	[Address(RVA = "0x13434B4", Offset = "0x13434B4", VA = "0x13434B4")]
	private void OnRecievingWarning(IHAAMHPPLMG pID, PriorityWaringType hintType, bool longLast, bool postionFixed, Vector3 fixedPos)
	{
	}

	[Token(Token = "0x600F1A4")]
	[Address(RVA = "0x1344E04", Offset = "0x1344E04", VA = "0x1344E04")]
	private void DequeuePriorityHints()
	{
	}

	[Token(Token = "0x600F1A5")]
	[Address(RVA = "0x1342834", Offset = "0x1342834", VA = "0x1342834")]
	private void RemovePriorityHintsAt(int index)
	{
	}

	[Token(Token = "0x600F1A6")]
	[Address(RVA = "0x1345180", Offset = "0x1345180", VA = "0x1345180")]
	private void OnLocalPlayerBeHit(object[] data)
	{
	}

	[Token(Token = "0x600F1A7")]
	[Address(RVA = "0x13460D8", Offset = "0x13460D8", VA = "0x13460D8")]
	private IEnumerator RemoveHurtHint(float delayTime, ResourceID resourceID)
	{
		return null;
	}

	[Token(Token = "0x600F1A8")]
	[Address(RVA = "0x1346200", Offset = "0x1346200", VA = "0x1346200")]
	private void DequeueHurtHints(ResourceID resourceID)
	{
	}

	[Token(Token = "0x600F1A9")]
	[Address(RVA = "0x1343084", Offset = "0x1343084", VA = "0x1343084")]
	private void ClearAllPriorityHints()
	{
	}

	[Token(Token = "0x600F1AA")]
	[Address(RVA = "0x1342E5C", Offset = "0x1342E5C", VA = "0x1342E5C")]
	private void ClearAllHurtHints()
	{
	}

	[Token(Token = "0x600F1AB")]
	[Address(RVA = "0x1345DC8", Offset = "0x1345DC8", VA = "0x1345DC8")]
	private void PlayBurningEffect()
	{
	}

	[Token(Token = "0x600F1AC")]
	[Address(RVA = "0x1346538", Offset = "0x1346538", VA = "0x1346538")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F1AD")]
	[Address(RVA = "0x1346540", Offset = "0x1346540", VA = "0x1346540")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F1AE")]
	[Address(RVA = "0x1346548", Offset = "0x1346548", VA = "0x1346548")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
