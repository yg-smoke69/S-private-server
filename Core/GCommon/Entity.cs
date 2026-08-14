using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EDC")]
public class Entity : MonoBehaviour, _Attribute, IConvertible
{
	[Token(Token = "0x401A887")]
	[FieldOffset(Offset = "0x0")]
	public static uint sUniqueEntityID;

	[Token(Token = "0x401A888")]
	[FieldOffset(Offset = "0xC")]
	public bool NeedUpdate;

	[Token(Token = "0x401A889")]
	[FieldOffset(Offset = "0xD")]
	public bool NeedStreamerUpdate;

	[Token(Token = "0x401A88A")]
	[FieldOffset(Offset = "0xE")]
	private bool m_VisibleHandlerRegistered;

	[Token(Token = "0x401A88B")]
	[FieldOffset(Offset = "0x10")]
	protected EntityInfo m_EntityInfo;

	[Token(Token = "0x401A88C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, ITransformNode> m_cachedTransformNodeDic;

	[Token(Token = "0x401A88D")]
	[FieldOffset(Offset = "0x24")]
	private ITransformNode m_emptyTransformNode;

	[Token(Token = "0x401A88E")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_CachedTransform;

	[Token(Token = "0x401A88F")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_UniqueID;

	[Token(Token = "0x401A890")]
	[FieldOffset(Offset = "0x30")]
	protected EEntityProxyType m_ProxyType;

	[Token(Token = "0x17001BF2")]
	public Transform CachedTransform
	{
		[Token(Token = "0x6019965")]
		[Address(RVA = "0x329E174", Offset = "0x329E174", VA = "0x329E174", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BF3")]
	public Vector3 Position
	{
		[Token(Token = "0x6019966")]
		[Address(RVA = "0x329E21C", Offset = "0x329E21C", VA = "0x329E21C", Slot = "12")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6019967")]
		[Address(RVA = "0x329E324", Offset = "0x329E324", VA = "0x329E324")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF4")]
	public Vector3 Forward
	{
		[Token(Token = "0x6019968")]
		[Address(RVA = "0x329E40C", Offset = "0x329E40C", VA = "0x329E40C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6019969")]
		[Address(RVA = "0x329E514", Offset = "0x329E514", VA = "0x329E514")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF5")]
	public Vector3 Right
	{
		[Token(Token = "0x601996A")]
		[Address(RVA = "0x329E5FC", Offset = "0x329E5FC", VA = "0x329E5FC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601996B")]
		[Address(RVA = "0x329E704", Offset = "0x329E704", VA = "0x329E704")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF6")]
	public Vector3 Up
	{
		[Token(Token = "0x601996C")]
		[Address(RVA = "0x329E7EC", Offset = "0x329E7EC", VA = "0x329E7EC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601996D")]
		[Address(RVA = "0x329E8F4", Offset = "0x329E8F4", VA = "0x329E8F4")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF7")]
	public Quaternion Rotation
	{
		[Token(Token = "0x601996E")]
		[Address(RVA = "0x329E9DC", Offset = "0x329E9DC", VA = "0x329E9DC", Slot = "13")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x601996F")]
		[Address(RVA = "0x329EAE4", Offset = "0x329EAE4", VA = "0x329EAE4")]
		set
		{
		}
	}

	[Token(Token = "0x17001BF8")]
	public uint UniqueID
	{
		[Token(Token = "0x6019970")]
		[Address(RVA = "0x329EBD4", Offset = "0x329EBD4", VA = "0x329EBD4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6019961")]
	[Address(RVA = "0x329E0C4", Offset = "0x329E0C4", VA = "0x329E0C4")]
	public Entity()
	{
	}

	[Token(Token = "0x6019962")]
	[Address(RVA = "0x329E0CC", Offset = "0x329E0CC", VA = "0x329E0CC")]
	private static uint GetUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x6019963")]
	[Address(RVA = "0x329E160", Offset = "0x329E160", VA = "0x329E160", Slot = "9")]
	public EntityInfo GetEntityInfo()
	{
		return default(EntityInfo);
	}

	[Token(Token = "0x6019964")]
	[Address(RVA = "0x329E170", Offset = "0x329E170", VA = "0x329E170", Slot = "10")]
	public virtual void InitEntityInfo()
	{
	}

	[Token(Token = "0x6019971")]
	[Address(RVA = "0x329EBDC", Offset = "0x329EBDC", VA = "0x329EBDC")]
	public void SetNeedStreamerUpdate(bool v)
	{
	}

	[Token(Token = "0x6019972")]
	[Address(RVA = "0x329EDA8", Offset = "0x329EDA8", VA = "0x329EDA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019973")]
	[Address(RVA = "0x329EE40", Offset = "0x329EE40", VA = "0x329EE40")]
	private void Start()
	{
	}

	[Token(Token = "0x6019974")]
	[Address(RVA = "0x329EEE8", Offset = "0x329EEE8", VA = "0x329EEE8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019975")]
	[Address(RVA = "0x329EBF0", Offset = "0x329EBF0", VA = "0x329EBF0")]
	public void RegisterVisibleHandler()
	{
	}

	[Token(Token = "0x6019976")]
	[Address(RVA = "0x329ECCC", Offset = "0x329ECCC", VA = "0x329ECCC")]
	public void UnregisterVisibleHandler()
	{
	}

	[Token(Token = "0x6019977")]
	[Address(RVA = "0x329EFA8", Offset = "0x329EFA8", VA = "0x329EFA8", Slot = "14")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x6019978")]
	[Address(RVA = "0x329EFAC", Offset = "0x329EFAC", VA = "0x329EFAC", Slot = "15")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x6019979")]
	[Address(RVA = "0x329EFB0", Offset = "0x329EFB0", VA = "0x329EFB0", Slot = "16")]
	protected virtual void OnOnDestroy()
	{
	}

	[Token(Token = "0x601997A")]
	[Address(RVA = "0x329EFB4", Offset = "0x329EFB4", VA = "0x329EFB4", Slot = "17")]
	public virtual void OnFixedUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x601997B")]
	[Address(RVA = "0x329EFB8", Offset = "0x329EFB8", VA = "0x329EFB8", Slot = "18")]
	public virtual void OnUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x601997C")]
	[Address(RVA = "0x329EFBC", Offset = "0x329EFBC", VA = "0x329EFBC", Slot = "19")]
	public virtual void OnPaused()
	{
	}

	[Token(Token = "0x601997D")]
	[Address(RVA = "0x329EFC0", Offset = "0x329EFC0", VA = "0x329EFC0", Slot = "20")]
	public virtual void OnResumed()
	{
	}

	[Token(Token = "0x601997E")]
	[Address(RVA = "0x329EFC4", Offset = "0x329EFC4", VA = "0x329EFC4")]
	public bool IsAutonomousProxy()
	{
		return default(bool);
	}

	[Token(Token = "0x601997F")]
	[Address(RVA = "0x329EFD8", Offset = "0x329EFD8", VA = "0x329EFD8")]
	public bool IsSimulatedProxy()
	{
		return default(bool);
	}

	[Token(Token = "0x6019980")]
	[Address(RVA = "0x329EFE8", Offset = "0x329EFE8", VA = "0x329EFE8")]
	public void SetAutonomousProxy()
	{
	}

	[Token(Token = "0x6019981")]
	[Address(RVA = "0x329EFF4", Offset = "0x329EFF4", VA = "0x329EFF4")]
	public void SetSimulatedProxy()
	{
	}

	[Token(Token = "0x6019982")]
	[Address(RVA = "0x329F000", Offset = "0x329F000", VA = "0x329F000")]
	public float GetMaxBoundsExtent()
	{
		return default(float);
	}

	[Token(Token = "0x6019983")]
	[Address(RVA = "0x329F128", Offset = "0x329F128", VA = "0x329F128", Slot = "21")]
	public virtual ITransformNode GetTransformNode(string name)
	{
		return null;
	}

	[Token(Token = "0x6019984")]
	[Address(RVA = "0x329F4B8", Offset = "0x329F4B8", VA = "0x329F4B8")]
	public static Transform FindTransformByName(GameObject go, string name)
	{
		return null;
	}

	[Token(Token = "0x6019985")]
	[Address(RVA = "0x329F6E4", Offset = "0x329F6E4", VA = "0x329F6E4")]
	public static Bounds GetMaxBounds(Transform obj)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Bounds);
	}

	[Token(Token = "0x6019986")]
	[Address(RVA = "0x329F894", Offset = "0x329F894", VA = "0x329F894")]
	public static float GetMaxBoundsExtent(Bounds bounds)
	{
		return default(float);
	}

	[Token(Token = "0x6019987")]
	[Address(RVA = "0x329F08C", Offset = "0x329F08C", VA = "0x329F08C")]
	public static float GetMaxBoundsExtent(Transform obj)
	{
		return default(float);
	}

	[Token(Token = "0x6019988")]
	[Address(RVA = "0x329FA00", Offset = "0x329FA00", VA = "0x329FA00", Slot = "22")]
	protected virtual void UpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}

	[Token(Token = "0x6019989")]
	[Address(RVA = "0x329FAF0", Offset = "0x329FAF0", VA = "0x329FAF0", Slot = "23")]
	protected virtual void OnUpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
	{
	}
}
