import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RoyalAccounting3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pattern pat = Pattern.compile("^([a-zA-Z]+);([-]?[0-9]+);([-]?[0-9]*\\.?[0-9]+);([a-zA-Z]+)$");
        TreeMap<String,Double> teamMap = new TreeMap<>();
        TreeMap<String,TreeMap<String,Double>> employeeMap = new TreeMap<>();
        TreeMap<String,TreeMap<String,Integer>> employeeHours = new TreeMap<>();
        ArrayList<String> employees = new ArrayList<>();
        String line = "";
        while(!(line = sc.nextLine()).equals("Pishi kuf i da si hodim")){
            Matcher match = pat.matcher(line);
            String employee ="";
            int workhours = 0;
            double payment = 0;
            String team = "";
            while(match.find()){
                employee = match.group(1);
                workhours = Integer.parseInt(match.group(2));
                payment = Double.parseDouble(match.group(3));
                team = match.group(4);
                if(employees.contains(employee)){
                    break;
                }else{
                    employees.add(employee);
                }
                double formulaMonth = ((payment*workhours)/(double)24)*(double)30;
                double formulaDay = ((payment*workhours)/(double)24);
                if(!teamMap.containsKey(team)){
                    teamMap.put(team,0d);
                    employeeMap.put(team, new TreeMap<>());
                    employeeHours.put(team,new TreeMap<>());
                }
                teamMap.put(team,teamMap.get(team)+formulaMonth);
                employeeHours.get(team).put(employee,workhours);
                employeeMap.get(team).put(employee,formulaDay);
            }
        }

        teamMap.entrySet().stream().sorted((t1,t2) -> Double.compare(t2.getValue(),t1.getValue()))
                .forEach(t1->{
                    System.out.printf("Team - %s\n", t1.getKey());
                    TreeMap<String, Double> sortPayment = employeeMap.get(t1.getKey());
                    TreeMap<String,Integer> sortHours = employeeHours.get(t1.getKey());
                    sortPayment.entrySet().stream().sorted((a,b)-> Double.compare(b.getValue(),a.getValue()))
                            .sorted((a,b)-> Integer.compare(sortHours.get(b.getKey()),sortHours.get(a.getKey()))).forEach(emp ->{
                        System.out.printf("$$$%s - %d - %.6f\n",emp.getKey(), sortHours.get(emp.getKey()),sortPayment.get(emp.getKey()));
                    });
                });
    }
}