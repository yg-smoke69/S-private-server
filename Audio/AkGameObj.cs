using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E22")]
public class AkGameObj : MonoBehaviour
{
	[Token(Token = "0x401A510")]
	[FieldOffset(Offset = "0xC")]
	private AkGameObjListenerList m_listeners;

	[Token(Token = "0x401A511")]
	[FieldOffset(Offset = "0x10")]
	public bool isEnvironmentAware;

	[Token(Token = "0x401A512")]
	[FieldOffset(Offset = "0x11")]
	private bool isStaticObject;

	[Token(Token = "0x401A513")]
	[FieldOffset(Offset = "0x14")]
	private Collider m_Collider;

	[Token(Token = "0x401A514")]
	[FieldOffset(Offset = "0x18")]
	private AkGameObjEnvironmentData m_envData;

	[Token(Token = "0x401A515")]
	[FieldOffset(Offset = "0x1C")]
	private AkGameObjPositionData m_posData;

	[Token(Token = "0x401A516")]
	[FieldOffset(Offset = "0x20")]
	public AkGameObjPositionOffsetData m_positionOffsetData;

	[Token(Token = "0x401A517")]
	[FieldOffset(Offset = "0x24")]
	private bool isRegistered;

	[Token(Token = "0x401A518")]
	[FieldOffset(Offset = "0x28")]
	private AkGameObjPosOffsetData m_posOffsetData;

	[Token(Token = "0x401A519")]
	private const int AK_NUM_LISTENERS = 8;

	[Token(Token = "0x401A51A")]
	[FieldOffset(Offset = "0x2C")]
	private int listenerMask;

	[Token(Token = "0x17001B87")]
	public bool IsUsingDefaultListeners
	{
		[Token(Token = "0x6019426")]
		[Address(RVA = "0x35D443C", Offset = "0x35D443C", VA = "0x35D443C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B88")]
	public List<AkAudioListener> ListenerList
	{
		[Token(Token = "0x6019427")]
		[Address(RVA = "0x35D4460", Offset = "0x35D4460", VA = "0x35D4460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019425")]
	[Address(RVA = "0x35D9384", Offset = "0x35D9384", VA = "0x35D9384")]
	public AkGameObj()
	{
	}

	[Token(Token = "0x6019428")]
	[Address(RVA = "0x35C45F8", Offset = "0x35C45F8", VA = "0x35C45F8")]
	internal void AddListener(AkAudioListener listener)
	{
	}

	[Token(Token = "0x6019429")]
	[Address(RVA = "0x35C4634", Offset = "0x35C4634", VA = "0x35C4634")]
	internal void RemoveListener(AkAudioListener listener)
	{
	}

	[Token(Token = "0x601942A")]
	[Address(RVA = "0x35C41CC", Offset = "0x35C41CC", VA = "0x35C41CC")]
	public AKRESULT Register()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601942B")]
	[Address(RVA = "0x35D9498", Offset = "0x35D9498", VA = "0x35D9498")]
	internal void SetPosition(bool force = false)
	{
	}

	[Token(Token = "0x601942C")]
	[Address(RVA = "0x35D9804", Offset = "0x35D9804", VA = "0x35D9804")]
	private void Awake()
	{
	}

	[Token(Token = "0x601942D")]
	[Address(RVA = "0x35D9FE8", Offset = "0x35D9FE8", VA = "0x35D9FE8")]
	private void CheckStaticStatus()
	{
	}

	[Token(Token = "0x601942E")]
	[Address(RVA = "0x35D9FEC", Offset = "0x35D9FEC", VA = "0x35D9FEC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601942F")]
	[Address(RVA = "0x35DA004", Offset = "0x35DA004", VA = "0x35DA004")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019430")]
	[Address(RVA = "0x35DA1C8", Offset = "0x35DA1C8", VA = "0x35DA1C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6019431")]
	[Address(RVA = "0x35DA260", Offset = "0x35DA260", VA = "0x35DA260", Slot = "4")]
	public virtual Vector3 GetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019432")]
	[Address(RVA = "0x35DA3F8", Offset = "0x35DA3F8", VA = "0x35DA3F8", Slot = "5")]
	public virtual Vector3 GetForward()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019433")]
	[Address(RVA = "0x35DA438", Offset = "0x35DA438", VA = "0x35DA438", Slot = "6")]
	public virtual Vector3 GetUpward()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019434")]
	[Address(RVA = "0x35DA478", Offset = "0x35DA478", VA = "0x35DA478")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6019435")]
	[Address(RVA = "0x35DA494", Offset = "0x35DA494", VA = "0x35DA494")]
	private void OnTriggerExit(Collider other)
	{
	}
}
