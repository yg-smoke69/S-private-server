using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002794")]
internal class UIHudItemMarkShowController : UIHudNameBaseController
{
	[Token(Token = "0x2002795")]
	private sealed class _003CMarkLineCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F476")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cspeed_003E__0;

		[Token(Token = "0x400F477")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cpercent_003E__0;

		[Token(Token = "0x400F478")]
		[FieldOffset(Offset = "0x10")]
		internal UISprite targetLine;

		[Token(Token = "0x400F479")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CendLength_003E__0;

		[Token(Token = "0x400F47A")]
		[FieldOffset(Offset = "0x18")]
		internal UIHudItemMarkShowController _0024this;

		[Token(Token = "0x400F47B")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400F47C")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400F47D")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x170011D1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F3EC")]
			[Address(RVA = "0x20ABDB8", Offset = "0x20ABDB8", VA = "0x20ABDB8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F3ED")]
			[Address(RVA = "0x20ABDC0", Offset = "0x20ABDC0", VA = "0x20ABDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F3EA")]
		[Address(RVA = "0x20AACDC", Offset = "0x20AACDC", VA = "0x20AACDC")]
		public _003CMarkLineCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F3EB")]
		[Address(RVA = "0x20ABB4C", Offset = "0x20ABB4C", VA = "0x20ABB4C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F3EE")]
		[Address(RVA = "0x20ABDC8", Offset = "0x20ABDC8", VA = "0x20ABDC8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F3EF")]
		[Address(RVA = "0x20ABDDC", Offset = "0x20ABDDC", VA = "0x20ABDDC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F466")]
	[FieldOffset(Offset = "0x50")]
	private UIHudItemMarkShowView m_View;

	[Token(Token = "0x400F467")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_bindWorldPosition;

	[Token(Token = "0x400F468")]
	[FieldOffset(Offset = "0x60")]
	private DLPJLPIHNCL m_ItemMarkType;

	[Token(Token = "0x400F469")]
	[FieldOffset(Offset = "0x64")]
	private uint m_ItemMarkId;

	[Token(Token = "0x400F46A")]
	[FieldOffset(Offset = "0x68")]
	private uint m_ItemMarkObjectId;

	[Token(Token = "0x400F46B")]
	[FieldOffset(Offset = "0x6C")]
	private Transform m_DistTrans;

	[Token(Token = "0x400F46C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3[] m_DistPosArray;

	[Token(Token = "0x400F46D")]
	[FieldOffset(Offset = "0x74")]
	private Transform m_Transform;

	[Token(Token = "0x400F46E")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_ContainerTrans;

	[Token(Token = "0x400F46F")]
	[FieldOffset(Offset = "0x7C")]
	public float SqrAlphaThreshold;

	[Token(Token = "0x400F470")]
	[FieldOffset(Offset = "0x80")]
	private int m_EnemyLineLen;

	[Token(Token = "0x400F471")]
	[FieldOffset(Offset = "0x84")]
	private int m_PickUpLineLen;

	[Token(Token = "0x400F472")]
	[FieldOffset(Offset = "0x88")]
	private float m_DistanceValue;

	[Token(Token = "0x400F473")]
	private const float HideThreshold = 100f;

	[Token(Token = "0x400F474")]
	[FieldOffset(Offset = "0x90")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x400F475")]
	[FieldOffset(Offset = "0xA8")]
	private UISprite m_TargetLine;

	[Token(Token = "0x600F3CB")]
	[Address(RVA = "0x20A9390", Offset = "0x20A9390", VA = "0x20A9390")]
	public UIHudItemMarkShowController()
	{
	}

	[Token(Token = "0x600F3CC")]
	[Address(RVA = "0x20A9444", Offset = "0x20A9444", VA = "0x20A9444")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F3CD")]
	[Address(RVA = "0x20A94E8", Offset = "0x20A94E8", VA = "0x20A94E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F3CE")]
	[Address(RVA = "0x20A9C84", Offset = "0x20A9C84", VA = "0x20A9C84")]
	public void SetUIShowData(DLPJLPIHNCL markType, uint markId, string markName, uint levelObjectId, int teamIndex, Vector3 targetPosition, IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x600F3CF")]
	[Address(RVA = "0x20AABF0", Offset = "0x20AABF0", VA = "0x20AABF0")]
	private IEnumerator MarkLineCoroutine(UISprite targetLine)
	{
		return null;
	}

	[Token(Token = "0x600F3D0")]
	[Address(RVA = "0x20AACE4", Offset = "0x20AACE4", VA = "0x20AACE4", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3D1")]
	[Address(RVA = "0x20AAD3C", Offset = "0x20AAD3C", VA = "0x20AAD3C")]
	private void ForceHide(object[] data)
	{
	}

	[Token(Token = "0x600F3D2")]
	[Address(RVA = "0x20AADA4", Offset = "0x20AADA4", VA = "0x20AADA4")]
	private void ResetUI()
	{
	}

	[Token(Token = "0x600F3D3")]
	[Address(RVA = "0x20AAEA8", Offset = "0x20AAEA8", VA = "0x20AAEA8")]
	public void RemoveMarkUI(DLPJLPIHNCL markType, uint markId, uint levelObjectId)
	{
	}

	[Token(Token = "0x600F3D4")]
	[Address(RVA = "0x20AAF5C", Offset = "0x20AAF5C", VA = "0x20AAF5C")]
	public void RemoveMarkUI()
	{
	}

	[Token(Token = "0x600F3D5")]
	[Address(RVA = "0x20AAFBC", Offset = "0x20AAFBC", VA = "0x20AAFBC", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3D6")]
	[Address(RVA = "0x20AB0C4", Offset = "0x20AB0C4", VA = "0x20AB0C4", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F3D7")]
	[Address(RVA = "0x20AB210", Offset = "0x20AB210", VA = "0x20AB210", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600F3D8")]
	[Address(RVA = "0x20AB298", Offset = "0x20AB298", VA = "0x20AB298", Slot = "40")]
	protected override void LateUpdate()
	{
	}

	[Token(Token = "0x600F3D9")]
	[Address(RVA = "0x20AB640", Offset = "0x20AB640", VA = "0x20AB640", Slot = "36")]
	protected override void OnDistanceChanged(float distance)
	{
	}

	[Token(Token = "0x600F3DA")]
	[Address(RVA = "0x20AB3AC", Offset = "0x20AB3AC", VA = "0x20AB3AC")]
	private void UpdateMarkAlpha()
	{
	}

	[Token(Token = "0x600F3DB")]
	[Address(RVA = "0x20AB6C4", Offset = "0x20AB6C4", VA = "0x20AB6C4", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3DC")]
	[Address(RVA = "0x20AB71C", Offset = "0x20AB71C", VA = "0x20AB71C", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3DD")]
	[Address(RVA = "0x20AB774", Offset = "0x20AB774", VA = "0x20AB774", Slot = "45")]
	protected override void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600F3DE")]
	[Address(RVA = "0x20AB7E8", Offset = "0x20AB7E8", VA = "0x20AB7E8", Slot = "39")]
	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	[Token(Token = "0x600F3DF")]
	[Address(RVA = "0x20ABADC", Offset = "0x20ABADC", VA = "0x20ABADC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F3E0")]
	[Address(RVA = "0x20ABAE4", Offset = "0x20ABAE4", VA = "0x20ABAE4")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3E1")]
	[Address(RVA = "0x20ABAEC", Offset = "0x20ABAEC", VA = "0x20ABAEC")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3E2")]
	[Address(RVA = "0x20ABAF4", Offset = "0x20ABAF4", VA = "0x20ABAF4")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F3E3")]
	[Address(RVA = "0x20ABB08", Offset = "0x20ABB08", VA = "0x20ABB08")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600F3E4")]
	[Address(RVA = "0x20ABB1C", Offset = "0x20ABB1C", VA = "0x20ABB1C")]
	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}

	[Token(Token = "0x600F3E5")]
	[Address(RVA = "0x20ABB24", Offset = "0x20ABB24", VA = "0x20ABB24")]
	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}

	[Token(Token = "0x600F3E6")]
	[Address(RVA = "0x20ABB2C", Offset = "0x20ABB2C", VA = "0x20ABB2C")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3E7")]
	[Address(RVA = "0x20ABB34", Offset = "0x20ABB34", VA = "0x20ABB34")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F3E8")]
	[Address(RVA = "0x20ABB3C", Offset = "0x20ABB3C", VA = "0x20ABB3C")]
	public void _003C_003EiFixBaseProxy_OnTrainingZoneChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F3E9")]
	[Address(RVA = "0x20ABB44", Offset = "0x20ABB44", VA = "0x20ABB44")]
	public void _003C_003EiFixBaseProxy_OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE P0)
	{
	}
}
