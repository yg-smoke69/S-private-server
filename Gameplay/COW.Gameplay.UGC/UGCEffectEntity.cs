using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C38")]
public class UGCEffectEntity : MonoBehaviour
{
	[Token(Token = "0x40064C2")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_effectObject;

	[Token(Token = "0x40064C3")]
	[FieldOffset(Offset = "0x10")]
	private PresentEffectEntity m_entityComm;

	[Token(Token = "0x40064C4")]
	[FieldOffset(Offset = "0x14")]
	private string m_entityID;

	[Token(Token = "0x40064C5")]
	[FieldOffset(Offset = "0x18")]
	private string TrackEntityID;

	[Token(Token = "0x40064C6")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 OffsetPosition;

	[Token(Token = "0x40064C7")]
	[FieldOffset(Offset = "0x28")]
	private Color Color;

	[Token(Token = "0x40064C8")]
	[FieldOffset(Offset = "0x38")]
	private Renderer[] CacheRenders;

	[Token(Token = "0x40064C9")]
	[FieldOffset(Offset = "0x0")]
	private static string[] ms_typeid2Name;

	[Token(Token = "0x40064CA")]
	[FieldOffset(Offset = "0x3C")]
	public Transform TrackObject;

	[Token(Token = "0x6005D54")]
	[Address(RVA = "0x2580850", Offset = "0x2580850", VA = "0x2580850")]
	public UGCEffectEntity()
	{
	}

	[Token(Token = "0x6005D55")]
	[Address(RVA = "0x2580894", Offset = "0x2580894", VA = "0x2580894")]
	private void OnColorChanged(int valueOld, int valueNew)
	{
	}

	[Token(Token = "0x6005D56")]
	[Address(RVA = "0x258095C", Offset = "0x258095C", VA = "0x258095C")]
	private void ApplyColor()
	{
	}

	[Token(Token = "0x6005D57")]
	[Address(RVA = "0x2580C50", Offset = "0x2580C50", VA = "0x2580C50")]
	public static void ChangeAnyObjectColor(GameObject go, int colorValue)
	{
	}

	[Token(Token = "0x6005D58")]
	[Address(RVA = "0x2580F6C", Offset = "0x2580F6C", VA = "0x2580F6C")]
	private void OnScaleChanged(float valueOld, float valueNew)
	{
	}

	[Token(Token = "0x6005D59")]
	[Address(RVA = "0x2581044", Offset = "0x2581044", VA = "0x2581044")]
	public void OnOffsetChanged(Vector3 valueOld, Vector3 valueNew)
	{
	}

	[Token(Token = "0x6005D5A")]
	[Address(RVA = "0x258112C", Offset = "0x258112C", VA = "0x258112C")]
	private void OnFollowTargetChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D5B")]
	[Address(RVA = "0x258128C", Offset = "0x258128C", VA = "0x258128C")]
	public void OnEffectTypeChanged_Int(int valueOld, int valueNew)
	{
	}

	[Token(Token = "0x6005D5C")]
	[Address(RVA = "0x2581714", Offset = "0x2581714", VA = "0x2581714")]
	public void OnEffectTypeChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D5D")]
	[Address(RVA = "0x2581B00", Offset = "0x2581B00", VA = "0x2581B00")]
	private void Update()
	{
	}

	[Token(Token = "0x6005D5E")]
	[Address(RVA = "0x2581B60", Offset = "0x2581B60", VA = "0x2581B60")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6005D5F")]
	[Address(RVA = "0x2581E58", Offset = "0x2581E58", VA = "0x2581E58")]
	public static UGCEffectEntity Create(string entityID)
	{
		return null;
	}

	[Token(Token = "0x6005D60")]
	[Address(RVA = "0x2582544", Offset = "0x2582544", VA = "0x2582544")]
	private void OnDestroy()
	{
	}
}
