using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB8")]
public abstract class TrailRenderer_Base : MonoBehaviour
{
	[Token(Token = "0x401A7B6")]
	[FieldOffset(Offset = "0xC")]
	public PCTrailRendererData TrailData;

	[Token(Token = "0x401A7B7")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_NoDecay;

	[Token(Token = "0x401A7B8")]
	[FieldOffset(Offset = "0x14")]
	private PCTrail m_ActiveTrail;

	[Token(Token = "0x401A7B9")]
	[FieldOffset(Offset = "0x18")]
	protected Transform m_Transform;

	[Token(Token = "0x401A7BA")]
	[FieldOffset(Offset = "0x1C")]
	private TrailManager m_Manager;

	[Token(Token = "0x6019822")]
	[Address(RVA = "0x323F66C", Offset = "0x323F66C", VA = "0x323F66C")]
	protected TrailRenderer_Base()
	{
	}

	[Token(Token = "0x6019823")]
	[Address(RVA = "0x3241280", Offset = "0x3241280", VA = "0x3241280", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6019824")]
	[Address(RVA = "0x323F730", Offset = "0x323F730", VA = "0x323F730", Slot = "5")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6019825")]
	[Address(RVA = "0x3241330", Offset = "0x3241330", VA = "0x3241330", Slot = "6")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6019826")]
	[Address(RVA = "0x32402F0", Offset = "0x32402F0", VA = "0x32402F0", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6019827")]
	[Address(RVA = "0x32428CC", Offset = "0x32428CC", VA = "0x32428CC", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6019828")]
	[Address(RVA = "0x32428F4", Offset = "0x32428F4", VA = "0x32428F4", Slot = "9")]
	protected virtual void OnTranslate(Vector3 t)
	{
	}

	[Token(Token = "0x6019829")]
	protected abstract Color GetMainColor();

	[Token(Token = "0x601982A")]
	protected abstract int GetMaxNumberOfPoints();

	[Token(Token = "0x601982B")]
	[Address(RVA = "0x323FAA0", Offset = "0x323FAA0", VA = "0x323FAA0", Slot = "12")]
	protected virtual void Reset()
	{
	}

	[Token(Token = "0x601982C")]
	[Address(RVA = "0x32428F8", Offset = "0x32428F8", VA = "0x32428F8", Slot = "13")]
	protected virtual void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	[Token(Token = "0x601982D")]
	[Address(RVA = "0x32428FC", Offset = "0x32428FC", VA = "0x32428FC", Slot = "14")]
	protected virtual void UpdateTrail(PCTrail trail, float deltaTime)
	{
	}

	[Token(Token = "0x601982E")]
	[Address(RVA = "0x323FE24", Offset = "0x323FE24", VA = "0x323FE24")]
	protected void AddPoint(Vector3 pos)
	{
	}

	[Token(Token = "0x601982F")]
	[Address(RVA = "0x3241458", Offset = "0x3241458", VA = "0x3241458")]
	private void GenerateMesh(PCTrail trail)
	{
	}

	[Token(Token = "0x6019830")]
	[Address(RVA = "0x3241334", Offset = "0x3241334", VA = "0x3241334")]
	private void UpdatePoints(PCTrail line, float deltaTime)
	{
	}

	[Token(Token = "0x6019831")]
	[Address(RVA = "0x3242A30", Offset = "0x3242A30", VA = "0x3242A30", Slot = "15")]
	protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime)
	{
	}

	[Token(Token = "0x6019832")]
	[Address(RVA = "0x3242900", Offset = "0x3242900", VA = "0x3242900")]
	private int NumberOfActivePoints(PCTrail line)
	{
		return default(int);
	}

	[Token(Token = "0x6019833")]
	[Address(RVA = "0x3242A34", Offset = "0x3242A34", VA = "0x3242A34")]
	protected void ToggleSizeInputStyle()
	{
	}

	[Token(Token = "0x6019834")]
	[Address(RVA = "0x3242A74", Offset = "0x3242A74", VA = "0x3242A74")]
	protected void ToggleColorInputStyle()
	{
	}

	[Token(Token = "0x6019835")]
	[Address(RVA = "0x3242AB4", Offset = "0x3242AB4", VA = "0x3242AB4")]
	public void LifeDecayEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6019836")]
	[Address(RVA = "0x3242AC0", Offset = "0x3242AC0", VA = "0x3242AC0")]
	public void Translate(Vector3 t)
	{
	}

	[Token(Token = "0x6019837")]
	[Address(RVA = "0x3242C7C", Offset = "0x3242C7C", VA = "0x3242C7C")]
	public void ClearSystem(bool emitState)
	{
	}

	[Token(Token = "0x6019838")]
	[Address(RVA = "0x3242CA4", Offset = "0x3242CA4", VA = "0x3242CA4", Slot = "16")]
	protected virtual void InitPCTrail(Type type)
	{
	}

	[Token(Token = "0x6019839")]
	[Address(RVA = "0x3242D30", Offset = "0x3242D30", VA = "0x3242D30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601983A")]
	[Address(RVA = "0x3242D44", Offset = "0x3242D44", VA = "0x3242D44")]
	private void OnDisable()
	{
	}
}
