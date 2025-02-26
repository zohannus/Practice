
public class CharacterStatus
{
    private static CharacterStatus Status;  // 싱글턴 인스턴스 저장
    public static CharacterStatus Instance => Status ??= new CharacterStatus();  // 싱글턴 객체 반환

    public string CharacterName = "";
    public float Hp { get; set; } = 100.0f;
    public float MaxHp { get; set; } = 100.0f;
    public float Mana { get; set; } = 20.0f;
    public float Atk { get; set; } = 10.0f;
    public float Amr { get; set; } = 1.0f;
    public int Money { get; set; } = 100000;
    public int EquipCode { get; set; } = 0;
    public float Damage { get; set; } = 10.0f;
    public int Locate { get; set; } = 0;
}