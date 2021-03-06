package javagameproject.Models.Gifts;

import javagameproject.Models.Weapons.Bullets.Bullet;
import javagameproject.Phase.PhaseManager;

import java.awt.*;

public class ArmorBonus extends Gift{

    private static final int bonusArmor = 230;
    private static final int giftWidth = 40;
    private static final int giftHeight = 40;
    private static final boolean isItBullet = false;
    private static final boolean isItArmor = true;
    private static final Bullet bulletType = PhaseManager.getCurrentLevel().getPlayer().getBulletType();
    private static final int giftNumber = 0;

    public ArmorBonus(int x, int y){
        super(bonusArmor, x, y, giftWidth, giftHeight, isItBullet, isItArmor, bulletType, giftNumber);
    }

    public void render(Graphics graphics){
        super.render(graphics);
    }

    public void update(){
        super.update();
    }
}
