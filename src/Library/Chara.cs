namespace Library;

public interface Chara
{ 
  string Name { get; }
  int Health { get; }
  void ReceiveDamage(int damage);
}