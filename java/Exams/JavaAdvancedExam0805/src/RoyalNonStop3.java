import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.*;

public class RoyalNonStop3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] firstline = sc.nextLine().split(" ");
        String[] secondLine = sc.nextLine().split(" ");
        int rows = Integer.parseInt(firstline[0]);
        int cols = Integer.parseInt(firstline[1]);
        BigDecimal lprice = new BigDecimal(secondLine[0]);
        BigDecimal rprice = new BigDecimal(secondLine[1]);
        int customers = 0;
        String line ="";
        BigDecimal money= BigDecimal.ZERO;

        while(!(line=sc.nextLine()).equals("Royal Close")){
            String []split = line.split(" ");
            int row = Integer.parseInt(split[0]);
            int col = Integer.parseInt(split[1]);
            if(row<col){
                for(int i=row;i>=0;i--){
                    BigDecimal r = BigDecimal.valueOf(i).add(BigDecimal.ONE);
                    BigDecimal c = BigDecimal.valueOf(col).add(BigDecimal.ONE);
                    BigDecimal formula = r.multiply(c);
                    if(i%2==0){
                        formula = formula.multiply(lprice);
                    }else{
                        formula =  formula.multiply(rprice);
                    }
                    money = money.add(formula);
                }
                for(int i=col-1;i>=1;i--){
                    BigDecimal c = BigDecimal.valueOf(i).add(BigDecimal.ONE);
                    BigDecimal formula = c.multiply(lprice);
                    money = money.add(formula);
                }
            }else{
                for(int i=col;i>=0;i--){
                    BigDecimal r = BigDecimal.valueOf(row).add(BigDecimal.ONE);
                    BigDecimal c = BigDecimal.valueOf(i).add(BigDecimal.ONE);
                    BigDecimal formula = r.multiply(c);
                    if(row%2==0){
                        formula = formula.multiply(lprice);
                    }else{
                        formula = formula.multiply(rprice);
                    }
                    money = money.add(formula);
                }
                for(int i=row-1;i>=1;i--){
                    BigDecimal r = BigDecimal.valueOf(i).add(BigDecimal.ONE);
                    BigDecimal c = BigDecimal.ONE;

                    BigDecimal formula = r.multiply(c);
                    if(i%2==0){
                        formula = formula.multiply(lprice);
                    }else{
                        formula = formula.multiply(rprice);
                    }
                    money =money.add(formula);
                }
            }
            customers++;
        }

        money = money.setScale(6,BigDecimal.ROUND_HALF_UP);
        System.out.println(money);
        System.out.println(customers);
    }
}