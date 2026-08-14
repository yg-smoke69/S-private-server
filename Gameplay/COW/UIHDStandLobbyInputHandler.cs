using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x200212C")]
public class UIHDStandLobbyInputHandler : MonoBehaviour
{
	[Token(Token = "0x200212D")]
	public enum RotateType
	{
		[Token(Token = "0x400CFD3")]
		None,
		[Token(Token = "0x400CFD4")]
		Scene,
		[Token(Token = "0x400CFD5")]
		Avatar
	}

	[Token(Token = "0x200212E")]
	private enum MouseButton
	{
		[Token(Token = "0x400CFD7")]
		Left,
		[Token(Token = "0x400CFD8")]
		Right,
		[Token(Token = "0x400CFD9")]
		Middle,
		[Token(Token = "0x400CFDA")]
		None
	}

	[Token(Token = "0x200212F")]
	private sealed class _003CMoveReducer_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CFDB")]
		[FieldOffset(Offset = "0x8")]
		internal float speed;

		[Token(Token = "0x400CFDC")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Cdirection_003E__0;

		[Token(Token = "0x400CFDD")]
		[FieldOffset(Offset = "0x10")]
		internal UIHDStandLobbyInputHandler _0024this;

		[Token(Token = "0x400CFDE")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400CFDF")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400CFE0")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001004")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600ADD1")]
			[Address(RVA = "0x20397E0", Offset = "0x20397E0", VA = "0x20397E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001005")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600ADD2")]
			[Address(RVA = "0x20397E8", Offset = "0x20397E8", VA = "0x20397E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600ADCF")]
		[Address(RVA = "0x2039514", Offset = "0x2039514", VA = "0x2039514")]
		public _003CMoveReducer_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600ADD0")]
		[Address(RVA = "0x203951C", Offset = "0x203951C", VA = "0x203951C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600ADD3")]
		[Address(RVA = "0x20397F0", Offset = "0x20397F0", VA = "0x20397F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600ADD4")]
		[Address(RVA = "0x2039804", Offset = "0x2039804", VA = "0x2039804", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CFBD")]
	[FieldOffset(Offset = "0xC")]
	private readonly string MouseHorizontalAxisName;

	[Token(Token = "0x400CFBE")]
	[FieldOffset(Offset = "0x10")]
	private readonly string MouseVerticalAxisName;

	[Token(Token = "0x400CFBF")]
	[FieldOffset(Offset = "0x14")]
	private readonly string MouseScrollAxisName;

	[Token(Token = "0x400CFC0")]
	[FieldOffset(Offset = "0x18")]
	public float PanMovementSensitivity;

	[Token(Token = "0x400CFC1")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 m_LastTouchPos;

	[Token(Token = "0x400CFC2")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 m_DownTouchPos;

	[Token(Token = "0x400CFC3")]
	[FieldOffset(Offset = "0x2C")]
	private float m_LastRotationAngle;

	[Token(Token = "0x400CFC4")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_MouseTouchStartPoint;

	[Token(Token = "0x400CFC5")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_InputEnable;

	[Token(Token = "0x400CFC6")]
	[FieldOffset(Offset = "0x40")]
	private float m_DownTime;

	[Token(Token = "0x400CFC7")]
	[FieldOffset(Offset = "0x44")]
	private float m_LastGotoYardTime;

	[Token(Token = "0x400CFC8")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 _position;

	[Token(Token = "0x400CFC9")]
	[FieldOffset(Offset = "0x54")]
	private Quaternion _rotation;

	[Token(Token = "0x400CFCA")]
	[FieldOffset(Offset = "0x64")]
	public Transform _avatarTransform;

	[Token(Token = "0x400CFCB")]
	[FieldOffset(Offset = "0x68")]
	private UIMaleAvatar m_avatar;

	[Token(Token = "0x400CFCC")]
	[FieldOffset(Offset = "0x6C")]
	public Transform m_petTransform;

	[Token(Token = "0x400CFCD")]
	[FieldOffset(Offset = "0x70")]
	private int m_fingerIndex;

	[Token(Token = "0x400CFCE")]
	[FieldOffset(Offset = "0x74")]
	private RotateType m_CurrentRotateType;

	[Token(Token = "0x400CFCF")]
	[FieldOffset(Offset = "0x78")]
	private float m_DpiFactor;

	[Token(Token = "0x400CFD0")]
	private const float IPHONE_DPI = 326f;

	[Token(Token = "0x400CFD1")]
	[FieldOffset(Offset = "0x7C")]
	private Coroutine m_CameraReducer;

	[Token(Token = "0x17001003")]
	private bool InputEnable
	{
		[Token(Token = "0x600ADC2")]
		[Address(RVA = "0x2036D50", Offset = "0x2036D50", VA = "0x2036D50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ADC1")]
		[Address(RVA = "0x2036CF0", Offset = "0x2036CF0", VA = "0x2036CF0")]
		set
		{
		}
	}

	[Token(Token = "0x600ADC0")]
	[Address(RVA = "0x2036B90", Offset = "0x2036B90", VA = "0x2036B90")]
	public UIHDStandLobbyInputHandler()
	{
	}

	[Token(Token = "0x600ADC3")]
	[Address(RVA = "0x2036E48", Offset = "0x2036E48", VA = "0x2036E48")]
	private void Awake()
	{
	}

	[Token(Token = "0x600ADC4")]
	[Address(RVA = "0x2036F30", Offset = "0x2036F30", VA = "0x2036F30")]
	private void Start()
	{
	}

	[Token(Token = "0x600ADC5")]
	[Address(RVA = "0x20373C0", Offset = "0x20373C0", VA = "0x20373C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600ADC6")]
	[Address(RVA = "0x203781C", Offset = "0x203781C", VA = "0x203781C")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADC7")]
	[Address(RVA = "0x20383F8", Offset = "0x20383F8", VA = "0x20383F8")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADC8")]
	[Address(RVA = "0x2038BC4", Offset = "0x2038BC4", VA = "0x2038BC4")]
	private void FingerUp(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADC9")]
	[Address(RVA = "0x2038DB4", Offset = "0x2038DB4", VA = "0x2038DB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600ADCA")]
	[Address(RVA = "0x2037DD4", Offset = "0x2037DD4", VA = "0x2037DD4")]
	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADCB")]
	[Address(RVA = "0x2038214", Offset = "0x2038214", VA = "0x2038214")]
	private void RotateLobbyScene(float angledelta = 0f)
	{
	}

	[Token(Token = "0x600ADCC")]
	[Address(RVA = "0x20390D0", Offset = "0x20390D0", VA = "0x20390D0")]
	public void SetEnableState(bool flag)
	{
	}

	[Token(Token = "0x600ADCD")]
	[Address(RVA = "0x2038638", Offset = "0x2038638", VA = "0x2038638")]
	private bool CheckIsTouchAvatar(Vector2 touchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADCE")]
	[Address(RVA = "0x2038CB8", Offset = "0x2038CB8", VA = "0x2038CB8")]
	private IEnumerator MoveReducer(float speed)
	{
		return null;
	}
}
