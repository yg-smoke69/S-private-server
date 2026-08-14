using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D11")]
public class ColliderStreamer : MonoBehaviour
{
	[Token(Token = "0x4019E95")]
	[FieldOffset(Offset = "0xC")]
	public string sceneName;

	[Token(Token = "0x4019E96")]
	[FieldOffset(Offset = "0x10")]
	public string scenePath;

	[Token(Token = "0x4019E97")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sceneGameObject;

	[Token(Token = "0x4019E98")]
	[FieldOffset(Offset = "0x18")]
	public ColliderStreamerManager colliderStreamerManager;

	[Token(Token = "0x4019E99")]
	[FieldOffset(Offset = "0x1C")]
	public bool playerOnlyActivate;

	[Token(Token = "0x4019E9A")]
	[FieldOffset(Offset = "0x20")]
	public float unloadTimer;

	[Token(Token = "0x4019E9B")]
	[FieldOffset(Offset = "0x24")]
	private bool loaded;

	[Token(Token = "0x6018746")]
	[Address(RVA = "0x230F534", Offset = "0x230F534", VA = "0x230F534")]
	public ColliderStreamer()
	{
	}

	[Token(Token = "0x6018747")]
	[Address(RVA = "0x230F544", Offset = "0x230F544", VA = "0x230F544")]
	private void Start()
	{
	}

	[Token(Token = "0x6018748")]
	[Address(RVA = "0x230F798", Offset = "0x230F798", VA = "0x230F798")]
	public void SetSceneGameObject(GameObject sceneGameObject)
	{
	}

	[Token(Token = "0x6018749")]
	[Address(RVA = "0x230F82C", Offset = "0x230F82C", VA = "0x230F82C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x601874A")]
	[Address(RVA = "0x230F92C", Offset = "0x230F92C", VA = "0x230F92C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x601874B")]
	[Address(RVA = "0x230FA74", Offset = "0x230FA74", VA = "0x230FA74")]
	private void UnloadScene()
	{
	}
}
